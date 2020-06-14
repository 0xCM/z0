//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines a set of common identity-related operations
    /// </summary>    
    public static class IdentityShare
    {
        [MethodImpl(Inline)]
        static string denullify(string test)
            => string.IsNullOrWhiteSpace(test) ? string.Empty : test;

        [MethodImpl(Inline)]
        static bool sequal(string a, string b, bool cased = false)
            => string.Equals(a,b, cased ? StringComparison.InvariantCulture : StringComparison.InvariantCultureIgnoreCase);

        [MethodImpl(Inline)]
        public static string format<T>(in T a)
            where T : IIdentified
                => denullify(a?.IdentityText);

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => denullify(a.IdentityText).CompareTo(b.IdentityText);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => sequal(a.IdentityText, b is T x ? x.IdentityText : string.Empty);   

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => sequal(a.IdentityText, b.IdentityText);   

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)     
            where T : IIdentified
                => denullify(src.IdentityText).GetHashCode();
    }
}