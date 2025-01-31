// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The category of the health error.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.HealthErrorCategoryTypeConverter))]
    public partial struct HealthErrorCategory :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("None", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Replication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Replication", "Replication", global::System.Management.Automation.CompletionResultType.ParameterValue, "Replication");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TestFailover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TestFailover", "TestFailover", global::System.Management.Automation.CompletionResultType.ParameterValue, "TestFailover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Configuration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Configuration", "Configuration", global::System.Management.Automation.CompletionResultType.ParameterValue, "Configuration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "FabricInfrastructure".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("FabricInfrastructure", "FabricInfrastructure", global::System.Management.Automation.CompletionResultType.ParameterValue, "FabricInfrastructure");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "VersionExpiry".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("VersionExpiry", "VersionExpiry", global::System.Management.Automation.CompletionResultType.ParameterValue, "VersionExpiry");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AgentAutoUpdateInfra".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AgentAutoUpdateInfra", "AgentAutoUpdateInfra", global::System.Management.Automation.CompletionResultType.ParameterValue, "AgentAutoUpdateInfra");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AgentAutoUpdateArtifactDeleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AgentAutoUpdateArtifactDeleted", "AgentAutoUpdateArtifactDeleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "AgentAutoUpdateArtifactDeleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AgentAutoUpdateRunAsAccount".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AgentAutoUpdateRunAsAccount", "AgentAutoUpdateRunAsAccount", global::System.Management.Automation.CompletionResultType.ParameterValue, "AgentAutoUpdateRunAsAccount");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AgentAutoUpdateRunAsAccountExpiry".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AgentAutoUpdateRunAsAccountExpiry", "AgentAutoUpdateRunAsAccountExpiry", global::System.Management.Automation.CompletionResultType.ParameterValue, "AgentAutoUpdateRunAsAccountExpiry");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AgentAutoUpdateRunAsAccountExpired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AgentAutoUpdateRunAsAccountExpired", "AgentAutoUpdateRunAsAccountExpired", global::System.Management.Automation.CompletionResultType.ParameterValue, "AgentAutoUpdateRunAsAccountExpired");
            }
        }
    }
}