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
    /// Characterizes an identifier
    /// </summary>
    public interface IIdentified
    {        
        string Identifier {get;}

        bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }               

        bool IsNonEmpty
        {            
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

    /// <summary>
    /// Defines a set of common identity-related operations
    /// </summary>    
    public readonly struct IdentityShare
    {
        [MethodImpl(Inline)]
        static string denullify(string test)
            => string.IsNullOrWhiteSpace(test) ? string.Empty : test;

        [MethodImpl(Inline)]
        static bool sequal(string a, string b, bool cased = false)
            => string.Equals(a,b, cased ? Cased : NoCase);

        [MethodImpl(Inline)]
        public static string format<T>(in T a)
            where T : IIdentified
                => denullify(a?.Identifier);

        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => sequal(a.Identifier, b is T x ? x.Identifier : string.Empty);   

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => sequal(a.Identifier, b.Identifier);   

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)     
            where T : IIdentified
                => denullify(src.Identifier).GetHashCode();
    }
}