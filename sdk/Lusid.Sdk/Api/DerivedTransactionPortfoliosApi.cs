/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1392
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDerivedTransactionPortfoliosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio
        /// </summary>
        /// <remarks>
        /// Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Portfolio</returns>
        Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null);

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio
        /// </summary>
        /// <remarks>
        /// Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        ApiResponse<Portfolio> CreateDerivedPortfolioWithHttpInfo (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null);
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details
        /// </summary>
        /// <remarks>
        /// Deletes the portfolio details for the specified derived transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details
        /// </summary>
        /// <remarks>
        /// Deletes the portfolio details for the specified derived transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        ApiResponse<DeletedEntityResponse> DeleteDerivedPortfolioDetailsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio
        /// </summary>
        /// <remarks>
        /// Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Task of Portfolio</returns>
        System.Threading.Tasks.Task<Portfolio> CreateDerivedPortfolioAsync (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null);

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio
        /// </summary>
        /// <remarks>
        /// Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreateDerivedPortfolioAsyncWithHttpInfo (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null);
        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details
        /// </summary>
        /// <remarks>
        /// Deletes the portfolio details for the specified derived transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        System.Threading.Tasks.Task<DeletedEntityResponse> DeleteDerivedPortfolioDetailsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null);

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details
        /// </summary>
        /// <remarks>
        /// Deletes the portfolio details for the specified derived transaction portfolio
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteDerivedPortfolioDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DerivedTransactionPortfoliosApi : IDerivedTransactionPortfoliosApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedTransactionPortfoliosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DerivedTransactionPortfoliosApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedTransactionPortfoliosApi"/> class
        /// </summary>
        /// <returns></returns>
        public DerivedTransactionPortfoliosApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedTransactionPortfoliosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DerivedTransactionPortfoliosApi(Lusid.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Portfolio</returns>
        public Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)
        {
             ApiResponse<Portfolio> localVarResponse = CreateDerivedPortfolioWithHttpInfo(scope, portfolio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>ApiResponse of Portfolio</returns>
        public ApiResponse< Portfolio > CreateDerivedPortfolioWithHttpInfo (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling DerivedTransactionPortfoliosApi->CreateDerivedPortfolio");

            var localVarPath = "./api/derivedtransactionportfolios/{scope}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (portfolio != null && portfolio.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolio); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolio; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateDerivedPortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Task of Portfolio</returns>
        public async System.Threading.Tasks.Task<Portfolio> CreateDerivedPortfolioAsync (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)
        {
             ApiResponse<Portfolio> localVarResponse = await CreateDerivedPortfolioAsyncWithHttpInfo(scope, portfolio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Create derived transaction portfolio Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \&quot;parent\&quot;. Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio&#39;s transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent&#39;s portfolio&#39;s, if it is also a derived portfolio, and so on).
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope into which to create the new derived portfolio</param>
        /// <param name="portfolio">The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional)</param>
        /// <returns>Task of ApiResponse (Portfolio)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Portfolio>> CreateDerivedPortfolioAsyncWithHttpInfo (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling DerivedTransactionPortfoliosApi->CreateDerivedPortfolio");

            var localVarPath = "./api/derivedtransactionportfolios/{scope}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (portfolio != null && portfolio.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(portfolio); // http body (model) parameter
            }
            else
            {
                localVarPostBody = portfolio; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateDerivedPortfolio", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Portfolio>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Portfolio) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Portfolio)));
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details Deletes the portfolio details for the specified derived transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>DeletedEntityResponse</returns>
        public DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = DeleteDerivedPortfolioDetailsWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details Deletes the portfolio details for the specified derived transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>ApiResponse of DeletedEntityResponse</returns>
        public ApiResponse< DeletedEntityResponse > DeleteDerivedPortfolioDetailsWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling DerivedTransactionPortfoliosApi->DeleteDerivedPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DerivedTransactionPortfoliosApi->DeleteDerivedPortfolioDetails");

            var localVarPath = "./api/derivedtransactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteDerivedPortfolioDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details Deletes the portfolio details for the specified derived transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>Task of DeletedEntityResponse</returns>
        public async System.Threading.Tasks.Task<DeletedEntityResponse> DeleteDerivedPortfolioDetailsAsync (string scope, string code, DateTimeOrCutLabel effectiveAt = null)
        {
             ApiResponse<DeletedEntityResponse> localVarResponse = await DeleteDerivedPortfolioDetailsAsyncWithHttpInfo(scope, code, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Delete portfolio details Deletes the portfolio details for the specified derived transaction portfolio
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope of the portfolio</param>
        /// <param name="code">The code of the portfolio</param>
        /// <param name="effectiveAt">The effective date of the change (optional)</param>
        /// <returns>Task of ApiResponse (DeletedEntityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedEntityResponse>> DeleteDerivedPortfolioDetailsAsyncWithHttpInfo (string scope, string code, DateTimeOrCutLabel effectiveAt = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling DerivedTransactionPortfoliosApi->DeleteDerivedPortfolioDetails");
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DerivedTransactionPortfoliosApi->DeleteDerivedPortfolioDetails");

            var localVarPath = "./api/derivedtransactionportfolios/{scope}/{code}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scope != null) localVarPathParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter
            if (effectiveAt != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "effectiveAt", effectiveAt)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteDerivedPortfolioDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeletedEntityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (DeletedEntityResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeletedEntityResponse)));
        }

    }
}
