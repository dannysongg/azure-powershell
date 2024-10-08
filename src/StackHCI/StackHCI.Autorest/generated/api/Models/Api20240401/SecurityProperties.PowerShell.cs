// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PowerShell;

    /// <summary>Security properties of the resource</summary>
    [System.ComponentModel.TypeConverter(typeof(SecurityPropertiesTypeConverter))]
    public partial class SecurityProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SecurityProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SecurityProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SecurityProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SecurityProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SecurityProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SecurityComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatus = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityComplianceStatus) content.GetValueForProperty("SecurityComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatus, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityComplianceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuredCoreComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecuredCoreComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("SecuredCoreComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecuredCoreComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("WdacComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).WdacComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("WdacComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).WdacComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("SmbEncryptionForIntraClusterTrafficComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SmbEncryptionForIntraClusterTrafficComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("SmbEncryptionForIntraClusterTrafficComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SmbEncryptionForIntraClusterTrafficComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusLastUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusLastUpdated = (global::System.DateTime?) content.GetValueForProperty("SecurityComplianceStatusLastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusLastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SecurityComplianceStatusSecuredCoreCompliance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusSecuredCoreCompliance = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusSecuredCoreCompliance",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusSecuredCoreCompliance, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusWdacCompliance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusWdacCompliance = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusWdacCompliance",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusWdacCompliance, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusDataAtRestEncrypted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataAtRestEncrypted = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusDataAtRestEncrypted",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataAtRestEncrypted, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusDataInTransitProtected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataInTransitProtected = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusDataInTransitProtected",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataInTransitProtected, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SecurityProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SecurityComplianceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatus = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityComplianceStatus) content.GetValueForProperty("SecurityComplianceStatus",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatus, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.SecurityComplianceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuredCoreComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecuredCoreComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("SecuredCoreComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecuredCoreComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("WdacComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).WdacComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("WdacComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).WdacComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("SmbEncryptionForIntraClusterTrafficComplianceAssignment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SmbEncryptionForIntraClusterTrafficComplianceAssignment = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType?) content.GetValueForProperty("SmbEncryptionForIntraClusterTrafficComplianceAssignment",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SmbEncryptionForIntraClusterTrafficComplianceAssignment, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceAssignmentType.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusLastUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusLastUpdated = (global::System.DateTime?) content.GetValueForProperty("SecurityComplianceStatusLastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusLastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SecurityComplianceStatusSecuredCoreCompliance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusSecuredCoreCompliance = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusSecuredCoreCompliance",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusSecuredCoreCompliance, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusWdacCompliance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusWdacCompliance = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusWdacCompliance",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusWdacCompliance, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusDataAtRestEncrypted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataAtRestEncrypted = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusDataAtRestEncrypted",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataAtRestEncrypted, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            if (content.Contains("SecurityComplianceStatusDataInTransitProtected"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataInTransitProtected = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus?) content.GetValueForProperty("SecurityComplianceStatusDataInTransitProtected",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ISecurityPropertiesInternal)this).SecurityComplianceStatusDataInTransitProtected, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ComplianceStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Security properties of the resource
    [System.ComponentModel.TypeConverter(typeof(SecurityPropertiesTypeConverter))]
    public partial interface ISecurityProperties

    {

    }
}