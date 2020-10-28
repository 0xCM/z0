//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using api = DispatcherProxies;

    partial class DispatchProxyGenerator
    {
        sealed class MethodInfoEqualityComparer : EqualityComparer<MethodInfo>
        {
            public readonly static MethodInfoEqualityComparer Instance
                = new MethodInfoEqualityComparer();

            private MethodInfoEqualityComparer() { }

            public sealed override bool Equals(MethodInfo? left, MethodInfo? right)
                => api.equals(left,right);

            public sealed override int GetHashCode(MethodInfo obj)
                => api.hash(obj);
        }
    }
}