// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a baseline metadata value.
    /// </summary>
    public partial class BaselineMetadataValue
    {
        /// <summary>
        /// Initializes a new instance of the BaselineMetadataValue class.
        /// </summary>
        public BaselineMetadataValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaselineMetadataValue class.
        /// </summary>
        /// <param name="name">the name of the metadata.</param>
        /// <param name="value">the value of the metadata.</param>
        public BaselineMetadataValue(LocalizableString name = default(LocalizableString), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                Name.Validate();
            }
        }
    }
}
