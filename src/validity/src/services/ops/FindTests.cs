//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class TestApp<A>
    {
        public MethodInfo[] FindTests(Type host)
            => host.NonSpecialMethods().Public().NonGeneric().WithArity(0);

        bool HasTests(Type host, string[] filters)
        {
            if(filters.Length != 0)
            {
                var hostpath = host.DisplayName();
                if(!(filters.Length == 1 && String.IsNullOrEmpty(filters[0])))
                    if(!hostpath.ContainsAny(filters))
                        return false;
            }
            return true;
        }
    }
}