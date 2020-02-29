//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    static class IdentityCommons
    {
        [MethodImpl(Inline)]
        public static string IdentityFormat<T>(in T a)
            where T : IIdentity<T>, new()
                => text.denullify(a?.Identifier);

        [MethodImpl(Inline)]
        public static int IdentityCompare<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool IdentityEquals<T>(in T a, object b)
            where T : IIdentity<T>, new()
                => text.equals(a.Identifier, b is T x ? x.Identifier : text.blank);   

        [MethodImpl(Inline)]
        public static bool IdentityEquals<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => text.equals(a.Identifier, b.Identifier);   

        [MethodImpl(Inline)]
        public static int IdentityHashCode<T>(in T src)     
            where T : IIdentity<T>, new()
                => text.denullify(src.Identifier).GetHashCode();
    }
}