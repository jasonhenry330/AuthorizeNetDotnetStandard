using AuthorizeNetDotnetStandard.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizeNetDotnetStandard
{
    public interface ICustomerProfileService
    {
        Task<CreateCustomerProfileResponse> CreateCustomerProfileAsync(string merchantCustomerId, string description, string email, CustomerContact billTo, CreditCard creditCard);
        Task<CreateCustomerPaymentProfileResponse> CreateCustomerPaymentProfileAsync(string customerProfileId, CustomerContact billTo, CreditCard creditCard);
        Task<GetCustomerPaymentProfileResponse> GetCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId);
        Task<UpdateCustomerPaymentProfileResponse> UpdateCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId, CustomerContact billTo, CreditCard creditCard);
        Task<DeleteCustomerPaymentProfileResponse> DeleteCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId);
        Task<ChargeCreditCardResponse> AuthorizeAndCaptureAsync(string customerProfileId, string customerPaymentProfileId, decimal amount, string customerIP, string referenceId);
    }

    public class CustomerProfileService : ICustomerProfileService
    {
        protected readonly Configuration _configuration;
        protected readonly MerchantAuthentication _merchantAuthentication;
        protected readonly IHttpClientFactory _httpClientFactory;

        public CustomerProfileService(IOptions<Configuration> configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration.Value;

            _merchantAuthentication = new MerchantAuthentication()
            {
                LoginId = _configuration.LoginId,
                TransactionKey = _configuration.TransactionKey
            };

            _httpClientFactory = httpClientFactory;
        }

        public async Task<CreateCustomerProfileResponse> CreateCustomerProfileAsync(string merchantCustomerId, string description, string email, CustomerContact billTo, CreditCard creditCard)
        {
            var createCustomerProfileRequest = new CreateCustomerProfileRequestWrapper()
            {
                CreateCustomerProfileRequest = new CreateCustomerProfileRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    ValidationMode = _configuration.ValidationMode,
                    CreateCustomerProfile = new CreateCustomerProfile()
                    {
                        MerchantCustomerId = String.Format("{0}-{1}", _configuration.RegionPrefix, merchantCustomerId),
                        Description = description,
                        Email = email,
                        CreateCustomerPaymentProfile = new CreateCustomerPaymentProfile()
                        {
                            CustomerType = "business",
                            BillTo = billTo,
                            Payment = new Payment()
                            {
                                CreditCard = creditCard
                            }
                        }
                    }
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(createCustomerProfileRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<CreateCustomerProfileResponse>(jsonResponse);
        }

        public async Task<CreateCustomerPaymentProfileResponse> CreateCustomerPaymentProfileAsync(string customerProfileId, CustomerContact billTo, CreditCard creditCard)
        {
            var createCustomerPaymentProfileRequest = new CreateCustomerPaymentProfileRequestWrapper()
            {
                CreateCustomerPaymentProfileRequest = new CreateCustomerPaymentProfileRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    ValidationMode = _configuration.ValidationMode,
                    CustomerProfileId = customerProfileId,
                    CreateCustomerPaymentProfile = new CreateCustomerPaymentProfile()
                    {
                        BillTo = billTo,
                        Payment = new Payment()
                        {
                            CreditCard = creditCard
                        }
                    }
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(createCustomerPaymentProfileRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<CreateCustomerPaymentProfileResponse>(jsonResponse);
        }

        public async Task<GetCustomerPaymentProfileResponse> GetCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId)
        {
            var getCustomerPaymentProfileRequest = new GetCustomerPaymentProfileRequestWrapper()
            {
                GetCustomerPaymentProfileRequest = new GetCustomerPaymentProfileRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    CustomerProfileId = customerProfileId,
                    CustomerPaymentProfileId = customerPaymentProfileId
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(getCustomerPaymentProfileRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<GetCustomerPaymentProfileResponse>(jsonResponse);
        }

        public async Task<UpdateCustomerPaymentProfileResponse> UpdateCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId, CustomerContact billTo, CreditCard creditCard)
        {
            var updateCustomerPaymentProfileRequest = new UpdateCustomerPaymentProfileRequestWrapper()
            {
                UpdateCustomerPaymentProfileRequest = new UpdateCustomerPaymentProfileRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    ValidationMode = _configuration.ValidationMode,
                    CustomerProfileId = customerProfileId,
                    PaymentProfile = new PaymentProfile()
                    {
                        CustomerPaymentProfileId = customerPaymentProfileId,
                        BillTo = billTo,
                        Payment = new Payment()
                        {
                            CreditCard = creditCard
                        }
                    }
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(updateCustomerPaymentProfileRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<UpdateCustomerPaymentProfileResponse>(jsonResponse);
        }

        public async Task<DeleteCustomerPaymentProfileResponse> DeleteCustomerPaymentProfileAsync(string customerProfileId, string customerPaymentProfileId)
        {
            var deleteCustomerPaymentProfileRequest = new DeleteCustomerPaymentProfileRequestWrapper()
            {
                GetCustomerPaymentProfileRequest = new GetCustomerPaymentProfileRequest()
                {
                    MerchantAuthentication = _merchantAuthentication,
                    CustomerProfileId = customerProfileId,
                    CustomerPaymentProfileId = customerPaymentProfileId
                }
            };

            var jsonRequest = new StringContent(
                JsonConvert.SerializeObject(deleteCustomerPaymentProfileRequest), Encoding.UTF8, "application/json");

            String jsonResponse;
            var httpClient = _httpClientFactory.CreateClient();

            using (var response = await httpClient.PostAsync(_configuration.URL, jsonRequest))
            { 
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<DeleteCustomerPaymentProfileResponse>(jsonResponse);
        }

        public async Task<ChargeCreditCardResponse> AuthorizeAndCaptureAsync(string customerProfileId, string customerPaymentProfileId, decimal amount, string customerIP, string referenceId)
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
                        CustomerIP = customerIP,
                        TransactionType = "authCaptureTransaction",
                        Profile = new CustomerProfile()
                        {
                            CustomerProfileId = customerProfileId,
                            PaymentProfile = new CustomerPaymentProfile()
                            {
                                PaymentProfileId = customerPaymentProfileId
                            }
                        },
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
    }
}
