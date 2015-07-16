namespace Fixtures.SwaggerBatRequiredOptional
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IExplicitModel
    {
        /// <summary>
        /// Test explicitly required integer. Please put null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredIntegerParameterWithHttpMessagesAsync(int? bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalIntegerParameterWithHttpMessagesAsync(int? bodyParameter = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required integer. Please put a valid int-wrapper
        /// with 'value' = null and the client library should throw before
        /// the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredIntegerPropertyWithHttpMessagesAsync(IntWrapper bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a valid int-wrapper
        /// with 'value' = null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalIntegerPropertyWithHttpMessagesAsync(IntOptionalWrapper bodyParameter = default(IntOptionalWrapper), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required integer. Please put a header
        /// 'headerParameter' =&gt; null and the client library should throw
        /// before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredIntegerHeaderWithHttpMessagesAsync(int? headerParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a header
        /// 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalIntegerHeaderWithHttpMessagesAsync(int? headerParameter = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredStringParameterWithHttpMessagesAsync(string bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional string. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalStringParameterWithHttpMessagesAsync(string bodyParameter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put a valid string-wrapper
        /// with 'value' = null and the client library should throw before
        /// the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredStringPropertyWithHttpMessagesAsync(StringWrapper bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a valid
        /// string-wrapper with 'value' = null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalStringPropertyWithHttpMessagesAsync(StringOptionalWrapper bodyParameter = default(StringOptionalWrapper), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put a header
        /// 'headerParameter' =&gt; null and the client library should throw
        /// before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredStringHeaderWithHttpMessagesAsync(string headerParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional string. Please put a header
        /// 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalStringHeaderWithHttpMessagesAsync(string bodyParameter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required complex object. Please put null and the
        /// client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredClassParameterWithHttpMessagesAsync(Product bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional complex object. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalClassParameterWithHttpMessagesAsync(Product bodyParameter = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required complex object. Please put a valid
        /// class-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredClassPropertyWithHttpMessagesAsync(ClassWrapper bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional complex object. Please put a valid
        /// class-wrapper with 'value' = null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalClassPropertyWithHttpMessagesAsync(ClassOptionalWrapper bodyParameter = default(ClassOptionalWrapper), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredArrayParameterWithHttpMessagesAsync(IList<string> bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional array. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalArrayParameterWithHttpMessagesAsync(IList<string> bodyParameter = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put a valid array-wrapper
        /// with 'value' = null and the client library should throw before
        /// the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredArrayPropertyWithHttpMessagesAsync(ArrayWrapper bodyParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional array. Please put a valid array-wrapper
        /// with 'value' = null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalArrayPropertyWithHttpMessagesAsync(ArrayOptionalWrapper bodyParameter = default(ArrayOptionalWrapper), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put a header
        /// 'headerParameter' =&gt; null and the client library should throw
        /// before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Error>> PostRequiredArrayHeaderWithHttpMessagesAsync(IList<string> headerParameter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a header
        /// 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostOptionalArrayHeaderWithHttpMessagesAsync(IList<string> headerParameter = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
