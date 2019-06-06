// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights_2018_04_04.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with QueryFailure information.
    /// </summary>
    public partial class QueryFailureException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public QueryFailure Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the QueryFailureException class.
        /// </summary>
        public QueryFailureException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QueryFailureException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public QueryFailureException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QueryFailureException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public QueryFailureException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
