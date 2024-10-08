// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support
{

    /// <summary>The voice codecs expected for communication with Teams.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.TeamsCodecsTypeConverter))]
    public partial struct TeamsCodecs :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PCMA".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PCMA'", "PCMA", global::System.Management.Automation.CompletionResultType.ParameterValue, "PCMA");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PCMU".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PCMU'", "PCMU", global::System.Management.Automation.CompletionResultType.ParameterValue, "PCMU");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G722".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G722'", "G722", global::System.Management.Automation.CompletionResultType.ParameterValue, "G722");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G722_2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G722_2'", "G722_2", global::System.Management.Automation.CompletionResultType.ParameterValue, "G722_2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SILK_8".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SILK_8'", "SILK_8", global::System.Management.Automation.CompletionResultType.ParameterValue, "SILK_8");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SILK_16".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SILK_16'", "SILK_16", global::System.Management.Automation.CompletionResultType.ParameterValue, "SILK_16");
            }
        }
    }
}