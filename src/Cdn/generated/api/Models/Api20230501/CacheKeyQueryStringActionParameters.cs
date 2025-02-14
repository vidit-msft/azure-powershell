// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for the cache-key query string action.</summary>
    public partial class CacheKeyQueryStringActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheKeyQueryStringActionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheKeyQueryStringActionParametersInternal
    {

        /// <summary>Internal Acessors for TypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheKeyQueryStringActionParametersInternal.TypeName { get => this._typeName; set { {_typeName = value;} } }

        /// <summary>Backing field for <see cref="QueryParameter" /> property.</summary>
        private string _queryParameter;

        /// <summary>query parameters to include or exclude (comma separated).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string QueryParameter { get => this._queryParameter; set => this._queryParameter = value; }

        /// <summary>Backing field for <see cref="QueryStringBehavior" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior _queryStringBehavior;

        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior QueryStringBehavior { get => this._queryStringBehavior; set => this._queryStringBehavior = value; }

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName= @"DeliveryRuleCacheKeyQueryStringBehaviorActionParameters";

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; }

        /// <summary>Creates an new <see cref="CacheKeyQueryStringActionParameters" /> instance.</summary>
        public CacheKeyQueryStringActionParameters()
        {

        }
    }
    /// Defines the parameters for the cache-key query string action.
    public partial interface ICacheKeyQueryStringActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>query parameters to include or exclude (comma separated).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"query parameters to include or exclude (comma separated).",
        SerializedName = @"queryParameters",
        PossibleTypes = new [] { typeof(string) })]
        string QueryParameter { get; set; }
        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Caching behavior for the requests",
        SerializedName = @"queryStringBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior QueryStringBehavior { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string TypeName { get;  }

    }
    /// Defines the parameters for the cache-key query string action.
    internal partial interface ICacheKeyQueryStringActionParametersInternal

    {
        /// <summary>query parameters to include or exclude (comma separated).</summary>
        string QueryParameter { get; set; }
        /// <summary>Caching behavior for the requests</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringBehavior QueryStringBehavior { get; set; }

        string TypeName { get; set; }

    }
}