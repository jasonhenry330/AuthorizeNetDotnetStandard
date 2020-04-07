using AuthorizeNetDotnetStandard.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizeNetDotnetStandard
{
    public interface ICreditCardService
    {
        Task<ChargeCreditCardResponse> AuthorizeAndCaptureAsync(
            CreditCard card, CustomerContact billToCustomer, decimal amount, string customerIP, string referenceId);
        Task<RefundResponse> RefundAsync(string transactionId, string creditCardLastFourDigits, decimal amount);
    }
    public class CreditCardService : ICreditCardService
    {
        protected readonly Configuration _configuration;
        protected readonly MerchantAuthentication _merchantAuthentication;
        protected readonly IHttpClientFactory _httpClientFactory;

        public CreditCardService (IOptions<Configuration> configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration.Value;

            _merchantAuthentication = new MerchantAuthentication()
            {
                LoginId = _configuration.LoginId,
                TransactionKey = _configuration.TransactionKey
            };

            _httpClientFactory = httpClientFactory;
        }

        public async Task<ChargeCreditCardResponse> AuthorizeAndCaptureAsync(
            CreditCard card, CustomerContact billToCustomer, decimal amount, string customerIP, string referenceId)
        {
            var chargeCreditCardRequest = new ChargeCreditCardRequest()
            {
                CreateTransactionRequest =  new CreateTransactionRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    ReferenceId = referenceId,
                    TransactionRequest = new TransactionRequest()
                    {
                        Amount = amount.ToString(), 
                        BillTo = billToCustomer,
                        CustomerIP = customerIP,
                        TransactionType = "authCaptureTransaction",
                        Payment = new Payment() { CreditCard = card },
                        Order = new Order() { InvoiceNumber = referenceId }
                    }
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(chargeCreditCardRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<ChargeCreditCardResponse>(jsonResponse);
        }

        public async Task<RefundResponse> RefundAsync(string transactionId, string creditCardLastFourDigits, decimal amount)
        {
            var refundRequest = new RefundRequest()
            {
                CreateTransactionRequest =  new CreateTransactionRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    TransactionRequest = new TransactionRequest()
                    {
                        ReferenceTransactionId = transactionId,
                        Amount = amount.ToString(), 
                        TransactionType = "refundTransaction",
                        Payment = new Payment() { CreditCard = new CreditCard() { CardNumber = creditCardLastFourDigits, ExpirationDate = "XXXX" } }
                    }
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(refundRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<RefundResponse>(jsonResponse);
        }
    }
}
