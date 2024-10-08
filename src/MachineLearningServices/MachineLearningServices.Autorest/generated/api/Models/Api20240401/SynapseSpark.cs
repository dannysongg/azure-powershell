// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>A SynapseSpark compute.</summary>
    public partial class SynapseSpark :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICompute"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICompute __compute = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.Compute();

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? AutoPausePropertyDelayInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPausePropertyDelayInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPausePropertyDelayInMinute = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? AutoPausePropertyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPausePropertyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPausePropertyEnabled = value ?? default(bool); }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? AutoScalePropertyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyEnabled = value ?? default(bool); }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? AutoScalePropertyMaxNodeCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyMaxNodeCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyMaxNodeCount = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? AutoScalePropertyMinNodeCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyMinNodeCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScalePropertyMinNodeCount = value ?? default(int); }

        /// <summary>The time at which the compute was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).CreatedOn; }

        /// <summary>The description of the Machine Learning compute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Description = value ?? null; }

        /// <summary>
        /// Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? DisableLocalAuth { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).DisableLocalAuth; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).DisableLocalAuth = value ?? default(bool); }

        /// <summary>
        /// Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned
        /// it if false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? IsAttachedCompute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).IsAttachedCompute; }

        /// <summary>Location for the underlying compute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Location = value ?? null; }

        /// <summary>Internal Acessors for CreatedOn</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal.CreatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).CreatedOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).CreatedOn = value; }

        /// <summary>Internal Acessors for IsAttachedCompute</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal.IsAttachedCompute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).IsAttachedCompute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).IsAttachedCompute = value; }

        /// <summary>Internal Acessors for ModifiedOn</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal.ModifiedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ModifiedOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ModifiedOn = value; }

        /// <summary>Internal Acessors for ProvisioningError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[] Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal.ProvisioningError { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningError; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningError = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningState = value; }

        /// <summary>Internal Acessors for AutoPauseProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoPauseProperties Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal.AutoPauseProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPauseProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoPauseProperty = value; }

        /// <summary>Internal Acessors for AutoScaleProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoScaleProperties Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal.AutoScaleProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScaleProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).AutoScaleProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSparkProperties()); set { {_property = value;} } }

        /// <summary>The time at which the compute was last modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? ModifiedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ModifiedOn; }

        /// <summary>The number of compute nodes currently assigned to the compute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? NodeCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeCount = value ?? default(int); }

        /// <summary>Node size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string NodeSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeSize = value ?? null; }

        /// <summary>Node size family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string NodeSizeFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeSizeFamily; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).NodeSizeFamily = value ?? null; }

        /// <summary>Pool name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string PoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).PoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).PoolName = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSparkProperties()); set => this._property = value; }

        /// <summary>Errors during provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[] ProvisioningError { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningError; }

        /// <summary>
        /// The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ProvisioningState; }

        /// <summary>Name of the resource group in which workspace is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).ResourceGroup = value ?? null; }

        /// <summary>ARM resource id of the underlying compute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).ResourceId = value ?? null; }

        /// <summary>Spark version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SparkVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).SparkVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).SparkVersion = value ?? null; }

        /// <summary>Azure subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).SubscriptionId = value ?? null; }

        /// <summary>The type of compute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)__compute).Type = value ; }

        /// <summary>Name of Azure Machine Learning workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string WorkspaceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).WorkspaceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkPropertiesInternal)Property).WorkspaceName = value ?? null; }

        /// <summary>Creates an new <see cref="SynapseSpark" /> instance.</summary>
        public SynapseSpark()
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
            await eventListener.AssertNotNull(nameof(__compute), __compute);
            await eventListener.AssertObjectIsValid(nameof(__compute), __compute);
        }
    }
    /// A SynapseSpark compute.
    public partial interface ISynapseSpark :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICompute
    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"delayInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? AutoPausePropertyDelayInMinute { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoPausePropertyEnabled { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoScalePropertyEnabled { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"maxNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AutoScalePropertyMaxNodeCount { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AutoScalePropertyMinNodeCount { get; set; }
        /// <summary>The number of compute nodes currently assigned to the compute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of compute nodes currently assigned to the compute.",
        SerializedName = @"nodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? NodeCount { get; set; }
        /// <summary>Node size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Node size.",
        SerializedName = @"nodeSize",
        PossibleTypes = new [] { typeof(string) })]
        string NodeSize { get; set; }
        /// <summary>Node size family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Node size family.",
        SerializedName = @"nodeSizeFamily",
        PossibleTypes = new [] { typeof(string) })]
        string NodeSizeFamily { get; set; }
        /// <summary>Pool name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pool name.",
        SerializedName = @"poolName",
        PossibleTypes = new [] { typeof(string) })]
        string PoolName { get; set; }
        /// <summary>Name of the resource group in which workspace is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group in which workspace is located.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get; set; }
        /// <summary>Spark version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Spark version.",
        SerializedName = @"sparkVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SparkVersion { get; set; }
        /// <summary>Azure subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure subscription identifier.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Name of Azure Machine Learning workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Azure Machine Learning workspace.",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceName { get; set; }

    }
    /// A SynapseSpark compute.
    internal partial interface ISynapseSparkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal
    {
        /// <summary>Auto pause properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoPauseProperties AutoPauseProperty { get; set; }

        int? AutoPausePropertyDelayInMinute { get; set; }

        bool? AutoPausePropertyEnabled { get; set; }
        /// <summary>Auto scale properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoScaleProperties AutoScaleProperty { get; set; }

        bool? AutoScalePropertyEnabled { get; set; }

        int? AutoScalePropertyMaxNodeCount { get; set; }

        int? AutoScalePropertyMinNodeCount { get; set; }
        /// <summary>The number of compute nodes currently assigned to the compute.</summary>
        int? NodeCount { get; set; }
        /// <summary>Node size.</summary>
        string NodeSize { get; set; }
        /// <summary>Node size family.</summary>
        string NodeSizeFamily { get; set; }
        /// <summary>Pool name.</summary>
        string PoolName { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties Property { get; set; }
        /// <summary>Name of the resource group in which workspace is located.</summary>
        string ResourceGroup { get; set; }
        /// <summary>Spark version.</summary>
        string SparkVersion { get; set; }
        /// <summary>Azure subscription identifier.</summary>
        string SubscriptionId { get; set; }
        /// <summary>Name of Azure Machine Learning workspace.</summary>
        string WorkspaceName { get; set; }

    }
}