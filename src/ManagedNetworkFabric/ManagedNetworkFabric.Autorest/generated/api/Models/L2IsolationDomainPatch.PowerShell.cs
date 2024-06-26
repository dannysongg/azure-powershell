// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.PowerShell;

    /// <summary>The L2 Isolation Domain patch resource definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(L2IsolationDomainPatchTypeConverter))]
    public partial class L2IsolationDomainPatch
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatch DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new L2IsolationDomainPatch(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatch DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new L2IsolationDomainPatch(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="L2IsolationDomainPatch" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="L2IsolationDomainPatch" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatch FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal L2IsolationDomainPatch(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatchPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.TagsUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Annotation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Annotation = (string) content.GetValueForProperty("Annotation",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Annotation, global::System.Convert.ToString);
            }
            if (content.Contains("Mtu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Mtu = (int?) content.GetValueForProperty("Mtu",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Mtu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal L2IsolationDomainPatch(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L2IsolationDomainPatchPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.TagsUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Annotation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Annotation = (string) content.GetValueForProperty("Annotation",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Annotation, global::System.Convert.ToString);
            }
            if (content.Contains("Mtu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Mtu = (int?) content.GetValueForProperty("Mtu",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL2IsolationDomainPatchInternal)this).Mtu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The L2 Isolation Domain patch resource definition.
    [System.ComponentModel.TypeConverter(typeof(L2IsolationDomainPatchTypeConverter))]
    public partial interface IL2IsolationDomainPatch

    {

    }
}