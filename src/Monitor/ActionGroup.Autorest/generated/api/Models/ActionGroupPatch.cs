// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.Extensions;

    /// <summary>An Azure action group for patch operations.</summary>
    public partial class ActionGroupPatch :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupPatch,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupPatchInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// Indicates whether this action group is enabled. If an action group is not enabled, then none of its actions will be activated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="ActionGroupPatch" /> instance.</summary>
        public ActionGroupPatch()
        {

        }
    }
    /// An Azure action group for patch operations.
    public partial interface IActionGroupPatch :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether this action group is enabled. If an action group is not enabled, then none of its actions will be activated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether this action group is enabled. If an action group is not enabled, then none of its actions will be activated.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// An Azure action group for patch operations.
    internal partial interface IActionGroupPatchInternal

    {
        /// <summary>
        /// Indicates whether this action group is enabled. If an action group is not enabled, then none of its actions will be activated.
        /// </summary>
        bool? Enabled { get; set; }

    }
}