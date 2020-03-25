//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Identify;

    /// <summary>
    /// Defines a set of common identity-related operations
    /// </summary>    
    public static class IdentityShare
    {
        [MethodImpl(Inline)]
        public static string format<T>(in T a)
            where T : IIdentified
                => text.denullify(a?.Identifier);

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => text.equals(a.Identifier, b is T x ? x.Identifier : text.blank);   

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => text.equals(a.Identifier, b.Identifier);   

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)     
            where T : IIdentified
                => text.denullify(src.Identifier).GetHashCode();
    }
}