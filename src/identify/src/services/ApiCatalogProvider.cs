//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Describes an assembly that provides cataloged operations
    /// </summary>
    public readonly struct ApiCatalogProvider : IApiCatalogProvider
    {      
        public PartId PartId {get;}

        public Assembly Part {get;}           
 
        public IApiCatalog Operations {get;}

        [MethodImpl(Inline)]
        internal ApiCatalogProvider(PartId id, Assembly src, IApiCatalog catalog)
        {
            this.PartId = id;
            this.Part = src;
            this.Operations = catalog;
        }

        Type[] IApiCatalog.FunFactories 
            => Operations.FunFactories;

        ApiHost[] IApiCatalog.GenericApiHosts 
            => Operations.GenericApiHosts;

        ApiHost[] IApiCatalog.DirectApiHosts 
            => Operations.DirectApiHosts;

        BinaryResources IApiCatalog.Resources 
            => Operations.Resources;

        public ApiHost[] ApiHosts 
            => Operations.ApiHosts;
    }
}