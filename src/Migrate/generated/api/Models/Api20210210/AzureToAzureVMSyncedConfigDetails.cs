namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Azure to Azure VM synced configuration details.</summary>
    public partial class AzureToAzureVMSyncedConfigDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsInternal
    {

        /// <summary>Backing field for <see cref="InputEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint[] _inputEndpoint;

        /// <summary>The Azure VM input endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint[] InputEndpoint { get => this._inputEndpoint; set => this._inputEndpoint = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsTags _tag;

        /// <summary>The Azure VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.AzureToAzureVMSyncedConfigDetailsTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="AzureToAzureVMSyncedConfigDetails" /> instance.</summary>
        public AzureToAzureVMSyncedConfigDetails()
        {

        }
    }
    /// Azure to Azure VM synced configuration details.
    public partial interface IAzureToAzureVMSyncedConfigDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The Azure VM input endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure VM input endpoints.",
        SerializedName = @"inputEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint[] InputEndpoint { get; set; }
        /// <summary>The Azure VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure VM tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsTags Tag { get; set; }

    }
    /// Azure to Azure VM synced configuration details.
    internal partial interface IAzureToAzureVMSyncedConfigDetailsInternal

    {
        /// <summary>The Azure VM input endpoints.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint[] InputEndpoint { get; set; }
        /// <summary>The Azure VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAzureToAzureVMSyncedConfigDetailsTags Tag { get; set; }

    }
}