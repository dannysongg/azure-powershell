// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Oracle Cloud Storage linked service properties.
    /// </summary>
    public partial class OracleCloudStorageLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the OracleCloudStorageLinkedServiceTypeProperties class.
        /// </summary>
        public OracleCloudStorageLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OracleCloudStorageLinkedServiceTypeProperties class.
        /// </summary>

        /// <param name="accessKeyId">The access key identifier of the Oracle Cloud Storage Identity and Access
        /// Management (IAM) user. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="secretAccessKey">The secret access key of the Oracle Cloud Storage Identity and Access
        /// Management (IAM) user.
        /// </param>

        /// <param name="serviceUrl">This value specifies the endpoint to access with the Oracle Cloud Storage
        /// Connector. This is an optional property; change it only if you want to try
        /// a different service endpoint or want to switch between https and http.
        /// Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public OracleCloudStorageLinkedServiceTypeProperties(object accessKeyId = default(object), SecretBase secretAccessKey = default(SecretBase), object serviceUrl = default(object), string encryptedCredential = default(string))

        {
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.ServiceUrl = serviceUrl;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the access key identifier of the Oracle Cloud Storage Identity
        /// and Access Management (IAM) user. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accessKeyId")]
        public object AccessKeyId {get; set; }

        /// <summary>
        /// Gets or sets the secret access key of the Oracle Cloud Storage Identity and
        /// Access Management (IAM) user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretAccessKey")]
        public SecretBase SecretAccessKey {get; set; }

        /// <summary>
        /// Gets or sets this value specifies the endpoint to access with the Oracle
        /// Cloud Storage Connector. This is an optional property; change it only if
        /// you want to try a different service endpoint or want to switch between
        /// https and http. Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceUrl")]
        public object ServiceUrl {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedCredential")]
        public string EncryptedCredential {get; set; }
    }
}