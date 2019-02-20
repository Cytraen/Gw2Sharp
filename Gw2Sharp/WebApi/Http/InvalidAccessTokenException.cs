using System;
using Gw2Sharp.WebApi.V2.Models;

namespace Gw2Sharp.WebApi.Http
{
    /// <summary>
    /// A web API specific exception that's used when a request fails to authorize due to an invalid API key (code 403).
    /// </summary>
    /// <seealso cref="UnexpectedStatusException{Error}" />
    public class InvalidAccessTokenException : AuthorizationRequiredException
    {
        /// <summary>
        /// Creates a new <see cref="InvalidAccessTokenException"/>.
        /// </summary>
        /// <param name="request">The original request.</param>
        /// <param name="response">The response.</param>
        /// <exception cref="ArgumentNullException"><paramref name="request"/> or <paramref name="response"/> is <c>null</c>.</exception>
        public InvalidAccessTokenException(IHttpRequest request, IHttpResponse<ErrorObject> response) :
            base(request, response, AuthorizationError.InvalidKey)
        { }
    }
}
