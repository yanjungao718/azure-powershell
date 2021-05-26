
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Removes the default account from the scope.
.Description
Removes the default account from the scope.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
System.Boolean
.Link
https://docs.microsoft.com/powershell/module/az.purview/remove-azpurviewdefaultaccount
#>
function Remove-AzPurviewDefaultAccount {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Remove', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Query')]
    [System.String]
    # The tenant ID.
    ${ScopeTenantId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Query')]
    [System.String]
    # The scope for the default account.
    ${ScopeType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Query')]
    [System.String]
    # The Id of the scope object, for example if the scope is "Subscription" then it is the ID of that subscription.
    ${Scope},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Purview.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)


process {
    try {
        Az.Purview.internal\Remove-AzPurviewDefaultAccount @PSBoundParameters
    } catch {
        throw
    }
}

}
