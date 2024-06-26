// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// An update to an Azure SQL job agent.
    /// </summary>
    public partial class JobAgentUpdate
    {
        /// <summary>
        /// Initializes a new instance of the JobAgentUpdate class.
        /// </summary>
        public JobAgentUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobAgentUpdate class.
        /// </summary>

        /// <param name="identity">Managed identity assigned to job agent
        /// </param>

        /// <param name="sku">The name and tier of the SKU.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>
        public JobAgentUpdate(JobAgentIdentity identity = default(JobAgentIdentity), Sku sku = default(Sku), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Identity = identity;
            this.Sku = sku;
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets managed identity assigned to job agent
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public JobAgentIdentity Identity {get; set; }

        /// <summary>
        /// Gets or sets the name and tier of the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku {get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Identity != null)
            {
                this.Identity.Validate();
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }

        }
    }
}