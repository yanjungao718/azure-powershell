namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the target NICs.</summary>
    public partial class InMageAzureV2EnableProtectionInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="InMageAzureV2EnableProtectionInputTargetNicTags" /> instance.
        /// </summary>
        public InMageAzureV2EnableProtectionInputTargetNicTags()
        {

        }
    }
    /// The tags for the target NICs.
    public partial interface IInMageAzureV2EnableProtectionInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the target NICs.
    internal partial interface IInMageAzureV2EnableProtectionInputTargetNicTagsInternal

    {

    }
}