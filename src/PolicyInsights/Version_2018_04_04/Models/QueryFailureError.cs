// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights_2018_04.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error definition.
    /// </summary>
    public partial class QueryFailureError
    {
        /// <summary>
        /// Initializes a new instance of the QueryFailureError class.
        /// </summary>
        public QueryFailureError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryFailureError class.
        /// </summary>
        /// <param name="code">Service specific error code which serves as the
        /// substatus for the HTTP error code.</param>
        /// <param name="message">Description of the error.</param>
        public QueryFailureError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets service specific error code which serves as the substatus for
        /// the HTTP error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets description of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
