---
external help file:
Module Name: Az.Synapse
online version: https://docs.microsoft.com/powershell/module/az.synapse/update-azsynapseworkspace
schema: 2.0.0
---

# Update-AzSynapseWorkspace

## SYNOPSIS
Updates a workspace

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzSynapseWorkspace -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-IdentityType <ResourceIdentityType>] [-KeyName <String>] [-KeyVaultUrl <String>]
 [-ManagedVirtualNetworkSettingAllowedAadTenantIdsForLinking <String[]>]
 [-ManagedVirtualNetworkSettingLinkedAccessCheckOnTargetResource]
 [-ManagedVirtualNetworkSettingPreventDataExfiltration] [-PublicNetworkAccess <WorkspacePublicNetworkAccess>]
 [-PurviewConfigurationPurviewResourceId <String>] [-SqlAdministratorLoginPassword <String>]
 [-Tag <Hashtable>] [-WorkspaceRepositoryConfigurationAccountName <String>]
 [-WorkspaceRepositoryConfigurationCollaborationBranch <String>]
 [-WorkspaceRepositoryConfigurationHostName <String>] [-WorkspaceRepositoryConfigurationLastCommitId <String>]
 [-WorkspaceRepositoryConfigurationProjectName <String>]
 [-WorkspaceRepositoryConfigurationRepositoryName <String>]
 [-WorkspaceRepositoryConfigurationRootFolder <String>] [-WorkspaceRepositoryConfigurationTenantId <String>]
 [-WorkspaceRepositoryConfigurationType <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzSynapseWorkspace -InputObject <ISynapseIdentity> [-IdentityType <ResourceIdentityType>]
 [-KeyName <String>] [-KeyVaultUrl <String>]
 [-ManagedVirtualNetworkSettingAllowedAadTenantIdsForLinking <String[]>]
 [-ManagedVirtualNetworkSettingLinkedAccessCheckOnTargetResource]
 [-ManagedVirtualNetworkSettingPreventDataExfiltration] [-PublicNetworkAccess <WorkspacePublicNetworkAccess>]
 [-PurviewConfigurationPurviewResourceId <String>] [-SqlAdministratorLoginPassword <String>]
 [-Tag <Hashtable>] [-WorkspaceRepositoryConfigurationAccountName <String>]
 [-WorkspaceRepositoryConfigurationCollaborationBranch <String>]
 [-WorkspaceRepositoryConfigurationHostName <String>] [-WorkspaceRepositoryConfigurationLastCommitId <String>]
 [-WorkspaceRepositoryConfigurationProjectName <String>]
 [-WorkspaceRepositoryConfigurationRepositoryName <String>]
 [-WorkspaceRepositoryConfigurationRootFolder <String>] [-WorkspaceRepositoryConfigurationTenantId <String>]
 [-WorkspaceRepositoryConfigurationType <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates a workspace

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
The type of managed identity for the workspace

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceIdentityType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeyName
Workspace Key sub-resource name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyVaultUrl
Workspace Key sub-resource key vault url

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedVirtualNetworkSettingAllowedAadTenantIdsForLinking
Allowed Aad Tenant Ids For Linking

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedVirtualNetworkSettingLinkedAccessCheckOnTargetResource
Linked Access Check On Target Resource

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedVirtualNetworkSettingPreventDataExfiltration
Prevent Data Exfiltration

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the workspace

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases: WorkspaceName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublicNetworkAccess
Enable or Disable public network access to workspace

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.WorkspacePublicNetworkAccess
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PurviewConfigurationPurviewResourceId
Purview Resource ID

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SqlAdministratorLoginPassword
SQL administrator login password

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationAccountName
Account name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationCollaborationBranch
Collaboration branch

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationHostName
GitHub Enterprise host name.
For example: https://github.mydomain.com

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationLastCommitId
The last commit ID

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationProjectName
VSTS project name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationRepositoryName
Repository name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationRootFolder
Root folder to use in the repository

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationTenantId
The VSTS tenant ID

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceRepositoryConfigurationType
Type of workspace repositoryID configuration.
Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210301.IWorkspace

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISynapseIdentity>: Identity Parameter
  - `[BaselineName <VulnerabilityAssessmentPolicyBaselineName?>]`: The name of the vulnerability assessment rule baseline (default implies a baseline on a Sql pool level rule and master for workspace level rule).
  - `[BigDataPoolName <String>]`: Big Data pool name
  - `[BlobAuditingPolicyName <String>]`: The name of the blob auditing policy.
  - `[ColumnName <String>]`: The name of the column.
  - `[ConnectionPolicyName <ConnectionPolicyName?>]`: The name of the connection policy.
  - `[DataMaskingPolicyName <DataMaskingPolicyName?>]`: The name of the data masking policy for which the masking rule applies.
  - `[DataMaskingRuleName <String>]`: The name of the data masking rule.
  - `[DataWarehouseUserActivityName <DataWarehouseUserActivityName?>]`: The activity name of the Sql pool. 
  - `[GeoBackupPolicyName <GeoBackupPolicyName?>]`: The name of the geo backup policy.
  - `[Id <String>]`: Resource identity path
  - `[IntegrationRuntimeName <String>]`: Integration runtime name
  - `[KeyName <String>]`: The name of the workspace key
  - `[LinkId <String>]`: The ID of the replication link.
  - `[NodeName <String>]`: Integration runtime node name
  - `[OperationId <String>]`: Operation ID
  - `[PrivateLinkHubName <String>]`: Name of the privateLinkHub
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[RestorableDroppedSqlPoolId <String>]`: The id of the deleted Sql Pool in the form of sqlPoolName,deletionTimeInFileTimeFormat
  - `[RestorePointName <String>]`: The name of the restore point.
  - `[RuleId <String>]`: The vulnerability assessment rule ID.
  - `[RuleName <String>]`: The IP firewall rule name
  - `[ScanId <String>]`: The vulnerability assessment scan Id of the scan to retrieve.
  - `[SchemaName <String>]`: The name of the schema.
  - `[SecurityAlertPolicyName <SecurityAlertPolicyName?>]`: The name of the security alert policy.
  - `[SensitivityLabelSource <WritableSensitivityLabelSource?>]`: The source of the sensitivity label.
  - `[SqlPoolName <String>]`: SQL pool name
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[TableName <String>]`: The name of the table.
  - `[TransparentDataEncryptionName <TransparentDataEncryptionName?>]`: The name of the transparent data encryption configuration.
  - `[VulnerabilityAssessmentName <VulnerabilityAssessmentName?>]`: The name of the vulnerability assessment.
  - `[WorkloadClassifierName <String>]`: The name of the workload classifier.
  - `[WorkloadGroupName <String>]`: The name of the workload group.
  - `[WorkspaceName <String>]`: The name of the workspace

## RELATED LINKS

