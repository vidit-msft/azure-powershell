// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for the cache expiration action.</summary>
    public partial class CacheExpirationActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal
    {

        /// <summary>Backing field for <see cref="CacheBehavior" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior _cacheBehavior;

        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior CacheBehavior { get => this._cacheBehavior; set => this._cacheBehavior = value; }

        /// <summary>Backing field for <see cref="CacheDuration" /> property.</summary>
        private string _cacheDuration;

        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CacheDuration { get => this._cacheDuration; set => this._cacheDuration = value; }

        /// <summary>Backing field for <see cref="CacheType" /> property.</summary>
        private string _cacheType= @"All";

        /// <summary>The level at which the content needs to be cached.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CacheType { get => this._cacheType; }

        /// <summary>Internal Acessors for CacheType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal.CacheType { get => this._cacheType; set { {_cacheType = value;} } }

        /// <summary>Internal Acessors for TypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal.TypeName { get => this._typeName; set { {_typeName = value;} } }

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName= @"DeliveryRuleCacheExpirationActionParameters";

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; }

        /// <summary>Creates an new <see cref="CacheExpirationActionParameters" /> instance.</summary>
        public CacheExpirationActionParameters()
        {

        }
    }
    /// Defines the parameters for the cache expiration action.
    public partial interface ICacheExpirationActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Caching behavior for the requests",
        SerializedName = @"cacheBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior CacheBehavior { get; set; }
        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss",
        SerializedName = @"cacheDuration",
        PossibleTypes = new [] { typeof(string) })]
        string CacheDuration { get; set; }
        /// <summary>The level at which the content needs to be cached.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The level at which the content needs to be cached.",
        SerializedName = @"cacheType",
        PossibleTypes = new [] { typeof(string) })]
        string CacheType { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string TypeName { get;  }

    }
    /// Defines the parameters for the cache expiration action.
    internal partial interface ICacheExpirationActionParametersInternal

    {
        /// <summary>Caching behavior for the requests</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior CacheBehavior { get; set; }
        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        string CacheDuration { get; set; }
        /// <summary>The level at which the content needs to be cached.</summary>
        string CacheType { get; set; }

        string TypeName { get; set; }

    }
}