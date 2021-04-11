/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace YNAB.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduledTransactionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Single scheduled transaction
        /// </summary>
        /// <remarks>
        /// Returns a single scheduled transaction
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <returns>ScheduledTransactionResponse</returns>
        ScheduledTransactionResponse GetScheduledTransactionById(string budgetId, string scheduledTransactionId);

        /// <summary>
        /// Single scheduled transaction
        /// </summary>
        /// <remarks>
        /// Returns a single scheduled transaction
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <returns>ApiResponse of ScheduledTransactionResponse</returns>
        ApiResponse<ScheduledTransactionResponse> GetScheduledTransactionByIdWithHttpInfo(string budgetId, string scheduledTransactionId);
        /// <summary>
        /// List scheduled transactions
        /// </summary>
        /// <remarks>
        /// Returns all scheduled transactions
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ScheduledTransactionsResponse</returns>
        ScheduledTransactionsResponse GetScheduledTransactions(string budgetId, long? lastKnowledgeOfServer = default(long?));

        /// <summary>
        /// List scheduled transactions
        /// </summary>
        /// <remarks>
        /// Returns all scheduled transactions
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ApiResponse of ScheduledTransactionsResponse</returns>
        ApiResponse<ScheduledTransactionsResponse> GetScheduledTransactionsWithHttpInfo(string budgetId, long? lastKnowledgeOfServer = default(long?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduledTransactionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Single scheduled transaction
        /// </summary>
        /// <remarks>
        /// Returns a single scheduled transaction
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScheduledTransactionResponse</returns>
        System.Threading.Tasks.Task<ScheduledTransactionResponse> GetScheduledTransactionByIdAsync(string budgetId, string scheduledTransactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Single scheduled transaction
        /// </summary>
        /// <remarks>
        /// Returns a single scheduled transaction
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScheduledTransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduledTransactionResponse>> GetScheduledTransactionByIdWithHttpInfoAsync(string budgetId, string scheduledTransactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List scheduled transactions
        /// </summary>
        /// <remarks>
        /// Returns all scheduled transactions
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScheduledTransactionsResponse</returns>
        System.Threading.Tasks.Task<ScheduledTransactionsResponse> GetScheduledTransactionsAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List scheduled transactions
        /// </summary>
        /// <remarks>
        /// Returns all scheduled transactions
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScheduledTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduledTransactionsResponse>> GetScheduledTransactionsWithHttpInfoAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduledTransactionsApi : IScheduledTransactionsApiSync, IScheduledTransactionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScheduledTransactionsApi : IScheduledTransactionsApi
    {
        private YNAB.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduledTransactionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduledTransactionsApi(String basePath)
        {
            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                new YNAB.SDK.Client.Configuration { BasePath = basePath }
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScheduledTransactionsApi(YNAB.SDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ScheduledTransactionsApi(YNAB.SDK.Client.ISynchronousClient client, YNAB.SDK.Client.IAsynchronousClient asyncClient, YNAB.SDK.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public YNAB.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public YNAB.SDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public YNAB.SDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public YNAB.SDK.Client.ExceptionFactory ExceptionFactory
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
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <returns>ScheduledTransactionResponse</returns>
        public ScheduledTransactionResponse GetScheduledTransactionById(string budgetId, string scheduledTransactionId)
        {
            YNAB.SDK.Client.ApiResponse<ScheduledTransactionResponse> localVarResponse = GetScheduledTransactionByIdWithHttpInfo(budgetId, scheduledTransactionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <returns>ApiResponse of ScheduledTransactionResponse</returns>
        public YNAB.SDK.Client.ApiResponse<ScheduledTransactionResponse> GetScheduledTransactionByIdWithHttpInfo(string budgetId, string scheduledTransactionId)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling ScheduledTransactionsApi->GetScheduledTransactionById");

            // verify the required parameter 'scheduledTransactionId' is set
            if (scheduledTransactionId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'scheduledTransactionId' when calling ScheduledTransactionsApi->GetScheduledTransactionById");

            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            localVarRequestOptions.PathParameters.Add("scheduled_transaction_id", YNAB.SDK.Client.ClientUtils.ParameterToString(scheduledTransactionId)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ScheduledTransactionResponse>("/budgets/{budget_id}/scheduled_transactions/{scheduled_transaction_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetScheduledTransactionById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScheduledTransactionResponse</returns>
        public async System.Threading.Tasks.Task<ScheduledTransactionResponse> GetScheduledTransactionByIdAsync(string budgetId, string scheduledTransactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            YNAB.SDK.Client.ApiResponse<ScheduledTransactionResponse> localVarResponse = await GetScheduledTransactionByIdWithHttpInfoAsync(budgetId, scheduledTransactionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Single scheduled transaction Returns a single scheduled transaction
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="scheduledTransactionId">The id of the scheduled transaction</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScheduledTransactionResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<ScheduledTransactionResponse>> GetScheduledTransactionByIdWithHttpInfoAsync(string budgetId, string scheduledTransactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling ScheduledTransactionsApi->GetScheduledTransactionById");

            // verify the required parameter 'scheduledTransactionId' is set
            if (scheduledTransactionId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'scheduledTransactionId' when calling ScheduledTransactionsApi->GetScheduledTransactionById");


            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            localVarRequestOptions.PathParameters.Add("scheduled_transaction_id", YNAB.SDK.Client.ClientUtils.ParameterToString(scheduledTransactionId)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ScheduledTransactionResponse>("/budgets/{budget_id}/scheduled_transactions/{scheduled_transaction_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetScheduledTransactionById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ScheduledTransactionsResponse</returns>
        public ScheduledTransactionsResponse GetScheduledTransactions(string budgetId, long? lastKnowledgeOfServer = default(long?))
        {
            YNAB.SDK.Client.ApiResponse<ScheduledTransactionsResponse> localVarResponse = GetScheduledTransactionsWithHttpInfo(budgetId, lastKnowledgeOfServer);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ApiResponse of ScheduledTransactionsResponse</returns>
        public YNAB.SDK.Client.ApiResponse<ScheduledTransactionsResponse> GetScheduledTransactionsWithHttpInfo(string budgetId, long? lastKnowledgeOfServer = default(long?))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling ScheduledTransactionsApi->GetScheduledTransactions");

            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer));
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ScheduledTransactionsResponse>("/budgets/{budget_id}/scheduled_transactions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetScheduledTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScheduledTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<ScheduledTransactionsResponse> GetScheduledTransactionsAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            YNAB.SDK.Client.ApiResponse<ScheduledTransactionsResponse> localVarResponse = await GetScheduledTransactionsWithHttpInfoAsync(budgetId, lastKnowledgeOfServer, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List scheduled transactions Returns all scheduled transactions
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScheduledTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<ScheduledTransactionsResponse>> GetScheduledTransactionsWithHttpInfoAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling ScheduledTransactionsApi->GetScheduledTransactions");


            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer));
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ScheduledTransactionsResponse>("/budgets/{budget_id}/scheduled_transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetScheduledTransactions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
