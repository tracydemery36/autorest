namespace Fixtures.Azure.SwaggerBatLro
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    /// <summary>
    /// Long-running Operation for AutoRest
    /// </summary>
    public partial interface ILROsCustomHeaderOperations
    {
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request, service returns a 200 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’. Poll the
        /// endpoint indicated in the Azure-AsyncOperation header for
        /// operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> PutAsyncRetrySucceededWithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request, service returns a 200 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’. Poll the
        /// endpoint indicated in the Azure-AsyncOperation header for
        /// operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> BeginPutAsyncRetrySucceededWithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request, service returns a 200 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’. Poll the
        /// endpoint indicated in the Azure-AsyncOperation header for
        /// operation status
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> GetAsyncRetrySucceededWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request, service returns a 201 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’.  Polls return
        /// this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> Put201CreatingSucceeded200WithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request, service returns a 201 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’.  Polls return
        /// this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> BeginPut201CreatingSucceeded200WithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running put
        /// request poller, service returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Product>> Get201CreatingSucceeded200PollingWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running post
        /// request, service returns a 202 to the initial request, with
        /// 'Location' and 'Retry-After' headers, Polls return a 200 with a
        /// response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> Post202Retry200WithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running post
        /// request, service returns a 202 to the initial request, with
        /// 'Location' and 'Retry-After' headers, Polls return a 200 with a
        /// response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPost202Retry200WithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running post
        /// request, service returns a 202 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’. Poll the
        /// endpoint indicated in the Azure-AsyncOperation header for
        /// operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PostAsyncRetrySucceededWithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is
        /// required message header for all requests. Long running post
        /// request, service returns a 202 to the initial request, with an
        /// entity that contains ProvisioningState=’Creating’. Poll the
        /// endpoint indicated in the Azure-AsyncOperation header for
        /// operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPostAsyncRetrySucceededWithHttpMessagesAsync(Product product = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
