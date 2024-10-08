// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Access with full SAS uri</summary>
    public partial class SasCredential :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISasCredential,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISasCredentialInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredential"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredential __dataReferenceCredential = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataReferenceCredential();

        /// <summary>[Required] Credential type used to authentication with storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataReferenceCredentialType CredentialType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredentialInternal)__dataReferenceCredential).CredentialType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredentialInternal)__dataReferenceCredential).CredentialType = value ; }

        /// <summary>Backing field for <see cref="SasUri" /> property.</summary>
        private string _sasUri;

        /// <summary>Full SAS Uri, including the storage, container/blob path and SAS token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string SasUri { get => this._sasUri; set => this._sasUri = value; }

        /// <summary>Creates an new <see cref="SasCredential" /> instance.</summary>
        public SasCredential()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dataReferenceCredential), __dataReferenceCredential);
            await eventListener.AssertObjectIsValid(nameof(__dataReferenceCredential), __dataReferenceCredential);
        }
    }
    /// Access with full SAS uri
    public partial interface ISasCredential :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredential
    {
        /// <summary>Full SAS Uri, including the storage, container/blob path and SAS token</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Full SAS Uri, including the storage, container/blob path and SAS token",
        SerializedName = @"sasUri",
        PossibleTypes = new [] { typeof(string) })]
        string SasUri { get; set; }

    }
    /// Access with full SAS uri
    internal partial interface ISasCredentialInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataReferenceCredentialInternal
    {
        /// <summary>Full SAS Uri, including the storage, container/blob path and SAS token</summary>
        string SasUri { get; set; }

    }
}