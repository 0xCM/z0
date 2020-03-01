//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    public static class IdentityOps
    {
        [MethodImpl(Inline)]
        public static string format<T>(in T a)
            where T : IIdentity<T>, new()
                => text.denullify(a?.Identifier);

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentity<T>, new()
                => text.equals(a.Identifier, b is T x ? x.Identifier : text.blank);   

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => text.equals(a.Identifier, b.Identifier);   

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)     
            where T : IIdentity<T>, new()
                => text.denullify(src.Identifier).GetHashCode();
    }
}