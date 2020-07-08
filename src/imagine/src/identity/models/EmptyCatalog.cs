//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// The catalog, it is empty
    /// </summary>
    public readonly struct EmptyCatalog : IPartCatalog
    {    
        public PartId PartId 
            => PartId.None;

        public Assembly Owner 
            => Assembly.GetEntryAssembly();

        public ApiHost[] Hosts 
            => Array.Empty<ApiHost>();

        public ApiHost[] GenericHosts 
            => Array.Empty<ApiHost>();

        public ApiHost[] DirectHosts 
            => Array.Empty<ApiHost>();

        public BinaryResources Resources 
            => BinaryResources.Empty;

        public Type[] FunFactories 
            => Array.Empty<Type>();
    }
}