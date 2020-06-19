//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
 
    public readonly struct ClosureProviderInfo
    {
        public ClosureProviderInfo(Type provider, MethodInfo[] supported)
        {
            this.ProviderType = provider;
            this.SupporedMethods = supported;
        }

        public Type ProviderType {get;}

        public MethodInfo[] SupporedMethods {get;}
    }

    public static class ClosureProviders
    {
        public static IDictionary<MethodInfo,Type> CreateIndex(IEnumerable<Type> src)
        {
            var query = from t in src
                        from m in t.DeclaredStaticMethods()
                        let tag = m.Tag<ClosureProviderAttribute>()
                        where tag.IsSome()
                        select (m, tag.Value.ProviderType);
            return query.ToDictionary();
        }
    }
}