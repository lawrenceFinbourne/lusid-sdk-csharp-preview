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
    public interface IResultsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
        /// </summary>
        /// <remarks>
        /// Retrieve pre-calculated results that have been stored in LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Results</returns>
        Results GetResults (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt);

        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
        /// </summary>
        /// <remarks>
        /// Retrieve pre-calculated results that have been stored in LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>ApiResponse of Results</returns>
        ApiResponse<Results> GetResultsWithHttpInfo (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt);
        /// <summary>
        /// [EXPERIMENTAL] Upsert results
        /// </summary>
        /// <remarks>
        /// Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Results</returns>
        Results UpsertResults (CreateResults request = null);

        /// <summary>
        /// [EXPERIMENTAL] Upsert results
        /// </summary>
        /// <remarks>
        /// Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>ApiResponse of Results</returns>
        ApiResponse<Results> UpsertResultsWithHttpInfo (CreateResults request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
        /// </summary>
        /// <remarks>
        /// Retrieve pre-calculated results that have been stored in LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Task of Results</returns>
        System.Threading.Tasks.Task<Results> GetResultsAsync (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt);

        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
        /// </summary>
        /// <remarks>
        /// Retrieve pre-calculated results that have been stored in LUSID.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Task of ApiResponse (Results)</returns>
        System.Threading.Tasks.Task<ApiResponse<Results>> GetResultsAsyncWithHttpInfo (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt);
        /// <summary>
        /// [EXPERIMENTAL] Upsert results
        /// </summary>
        /// <remarks>
        /// Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Task of Results</returns>
        System.Threading.Tasks.Task<Results> UpsertResultsAsync (CreateResults request = null);

        /// <summary>
        /// [EXPERIMENTAL] Upsert results
        /// </summary>
        /// <remarks>
        /// Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Task of ApiResponse (Results)</returns>
        System.Threading.Tasks.Task<ApiResponse<Results>> UpsertResultsAsyncWithHttpInfo (CreateResults request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResultsApi : IResultsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResultsApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ResultsApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResultsApi(Lusid.Sdk.Client.Configuration configuration = null)
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
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt. Retrieve pre-calculated results that have been stored in LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Results</returns>
        public Results GetResults (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt)
        {
             ApiResponse<Results> localVarResponse = GetResultsWithHttpInfo(entityScope, entityCode, calculationScope, calculationCode, effectiveAt);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt. Retrieve pre-calculated results that have been stored in LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>ApiResponse of Results</returns>
        public ApiResponse< Results > GetResultsWithHttpInfo (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt)
        {
            // verify the required parameter 'entityScope' is set
            if (entityScope == null)
                throw new ApiException(400, "Missing required parameter 'entityScope' when calling ResultsApi->GetResults");
            // verify the required parameter 'entityCode' is set
            if (entityCode == null)
                throw new ApiException(400, "Missing required parameter 'entityCode' when calling ResultsApi->GetResults");
            // verify the required parameter 'calculationScope' is set
            if (calculationScope == null)
                throw new ApiException(400, "Missing required parameter 'calculationScope' when calling ResultsApi->GetResults");
            // verify the required parameter 'calculationCode' is set
            if (calculationCode == null)
                throw new ApiException(400, "Missing required parameter 'calculationCode' when calling ResultsApi->GetResults");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling ResultsApi->GetResults");

            var localVarPath = "./api/results/{entityScope}/{entityCode}/{calculationScope}/{calculationCode}/{effectiveAt}";
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

            if (entityScope != null) localVarPathParams.Add("entityScope", this.Configuration.ApiClient.ParameterToString(entityScope)); // path parameter
            if (entityCode != null) localVarPathParams.Add("entityCode", this.Configuration.ApiClient.ParameterToString(entityCode)); // path parameter
            if (calculationScope != null) localVarPathParams.Add("calculationScope", this.Configuration.ApiClient.ParameterToString(calculationScope)); // path parameter
            if (calculationCode != null) localVarPathParams.Add("calculationCode", this.Configuration.ApiClient.ParameterToString(calculationCode)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResults", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Results>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Results) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Results)));
        }

        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt. Retrieve pre-calculated results that have been stored in LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Task of Results</returns>
        public async System.Threading.Tasks.Task<Results> GetResultsAsync (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt)
        {
             ApiResponse<Results> localVarResponse = await GetResultsAsyncWithHttpInfo(entityScope, entityCode, calculationScope, calculationCode, effectiveAt);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt. Retrieve pre-calculated results that have been stored in LUSID.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityScope">The scope of the data or entity being stored</param>
        /// <param name="entityCode">The identifier for the data or results entity being stored</param>
        /// <param name="calculationScope">The identifying scope for the calculation that produced the result</param>
        /// <param name="calculationCode">The identifying calculation name for the results</param>
        /// <param name="effectiveAt">The market date for which the data is stored</param>
        /// <returns>Task of ApiResponse (Results)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Results>> GetResultsAsyncWithHttpInfo (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt)
        {
            // verify the required parameter 'entityScope' is set
            if (entityScope == null)
                throw new ApiException(400, "Missing required parameter 'entityScope' when calling ResultsApi->GetResults");
            // verify the required parameter 'entityCode' is set
            if (entityCode == null)
                throw new ApiException(400, "Missing required parameter 'entityCode' when calling ResultsApi->GetResults");
            // verify the required parameter 'calculationScope' is set
            if (calculationScope == null)
                throw new ApiException(400, "Missing required parameter 'calculationScope' when calling ResultsApi->GetResults");
            // verify the required parameter 'calculationCode' is set
            if (calculationCode == null)
                throw new ApiException(400, "Missing required parameter 'calculationCode' when calling ResultsApi->GetResults");
            // verify the required parameter 'effectiveAt' is set
            if (effectiveAt == null)
                throw new ApiException(400, "Missing required parameter 'effectiveAt' when calling ResultsApi->GetResults");

            var localVarPath = "./api/results/{entityScope}/{entityCode}/{calculationScope}/{calculationCode}/{effectiveAt}";
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

            if (entityScope != null) localVarPathParams.Add("entityScope", this.Configuration.ApiClient.ParameterToString(entityScope)); // path parameter
            if (entityCode != null) localVarPathParams.Add("entityCode", this.Configuration.ApiClient.ParameterToString(entityCode)); // path parameter
            if (calculationScope != null) localVarPathParams.Add("calculationScope", this.Configuration.ApiClient.ParameterToString(calculationScope)); // path parameter
            if (calculationCode != null) localVarPathParams.Add("calculationCode", this.Configuration.ApiClient.ParameterToString(calculationCode)); // path parameter
            if (effectiveAt != null) localVarPathParams.Add("effectiveAt", this.Configuration.ApiClient.ParameterToString(effectiveAt)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResults", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Results>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Results) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Results)));
        }

        /// <summary>
        /// [EXPERIMENTAL] Upsert results Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Results</returns>
        public Results UpsertResults (CreateResults request = null)
        {
             ApiResponse<Results> localVarResponse = UpsertResultsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Upsert results Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>ApiResponse of Results</returns>
        public ApiResponse< Results > UpsertResultsWithHttpInfo (CreateResults request = null)
        {

            var localVarPath = "./api/results";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("UpsertResults", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Results>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Results) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Results)));
        }

        /// <summary>
        /// [EXPERIMENTAL] Upsert results Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Task of Results</returns>
        public async System.Threading.Tasks.Task<Results> UpsertResultsAsync (CreateResults request = null)
        {
             ApiResponse<Results> localVarResponse = await UpsertResultsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EXPERIMENTAL] Upsert results Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The details of what to upsert (optional)</param>
        /// <returns>Task of ApiResponse (Results)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Results>> UpsertResultsAsyncWithHttpInfo (CreateResults request = null)
        {

            var localVarPath = "./api/results";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("UpsertResults", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Results>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Results) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Results)));
        }

    }
}
