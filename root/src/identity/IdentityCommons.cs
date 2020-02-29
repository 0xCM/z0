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
        /// <summary>
        /// Compares two identifiers, ignoring case
        /// </summary>
        /// <param name="a">The left identity text</param>
        /// <param name="b">The right identity text</param>
        [MethodImpl(Inline)]
        static bool IdentityEquals(string a, string b)
            => text.equals(a, b);        

        [MethodImpl(Inline)]
        public static int IdentityCompare(IIdentity a, IIdentity b)
            => text.denullify(a?.Identifier).CompareTo(b?.Identifier);

        [MethodImpl(Inline)]
        public static string IdentityFormat(IIdentity a)
            => text.denullify(a?.Identifier);

        [MethodImpl(Inline)]
        public static bool IdentityEquals(IIdentity a, IIdentity b)
            => b is IIdentity i && IdentityEquals(a?.Identifier, i?.Identifier);        

        [MethodImpl(Inline)]
        public static int IdentityCompare<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool IdentityEquals<T>(in T a, object b)
            where T : IIdentity<T>, new()
                => IdentityEquals(a.Identifier, b is T x ? x.Identifier : text.blank);   

        [MethodImpl(Inline)]
        public static bool IdentityEquals<T>(in T a, in T b)
            where T : IIdentity<T>, new()
                => IdentityEquals(a.Identifier, b.Identifier);   

        [MethodImpl(Inline)]
        public static int IdentityHashCode<T>(in T src)     
            where T : IIdentity<T>, new()
                => text.denullify(src.Identifier).GetHashCode();
    }
}