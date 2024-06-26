// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>The response to a record set List operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class RecordSetListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSetListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSet[] _value;

        /// <summary>Information about the record sets in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSet[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="RecordSetListResult" /> instance.</summary>
        public RecordSetListResult()
        {

        }
    }
    /// The response to a record set List operation.
    public partial interface IRecordSetListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The continuation token for the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Information about the record sets in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Information about the record sets in the response.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSet) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSet[] Value { get; set; }

    }
    /// The response to a record set List operation.
    internal partial interface IRecordSetListResultInternal

    {
        /// <summary>The continuation token for the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Information about the record sets in the response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IRecordSet[] Value { get; set; }

    }
}