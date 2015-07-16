namespace Fixtures.Azure.SwaggerBatPaging
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class PagingOperationsExtensions
    {
            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetSinglePages(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetSinglePagesAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetSinglePagesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetMultiplePages(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetMultiplePagesRetryFirst(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetryFirstAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesRetryFirstAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesRetryFirstWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetMultiplePagesRetrySecond(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetrySecondAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesRetrySecondAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesRetrySecondWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetSinglePagesFailure(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesFailureAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetSinglePagesFailureAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetSinglePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetMultiplePagesFailure(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesFailureAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<Product> GetMultiplePagesFailureUri(this IPagingOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureUriAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesFailureUriAsync( this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesFailureUriWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetSinglePagesNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetSinglePagesNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetSinglePagesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetMultiplePagesNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetMultiplePagesRetryFirstNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetryFirstNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesRetryFirstNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesRetryFirstNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetMultiplePagesRetrySecondNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetrySecondNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesRetrySecondNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesRetrySecondNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetSinglePagesFailureNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesFailureNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetSinglePagesFailureNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetSinglePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetMultiplePagesFailureNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesFailureNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<Product> GetMultiplePagesFailureUriNext(this IPagingOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureUriNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<Product>> GetMultiplePagesFailureUriNextAsync( this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<Product>> result = await operations.GetMultiplePagesFailureUriNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
