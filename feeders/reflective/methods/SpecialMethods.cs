//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflective
    {

        static ReadOnlySpan<char> SpecialChars => new char[]{'<','>','|'};

        /// <summary>
        /// Determines whether a string contains any of the characters in a supplied sequence
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="chars">The characters for which to search</param>
        static bool ContainsAny(this string src, ReadOnlySpan<char> chars)
        {
            foreach (var c in chars)
                if (src.Contains(c))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a method is non-special as determined by either the IsSpecialName property 
        /// or the presence of a compiler-generated character in the method name
        /// </summary>
        /// <param name="src">The method to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpecial(this MethodInfo src)
            => src.IsSpecialName || src.Name.ContainsAny(SpecialChars);

        /// <summary>
        /// Determines whether a method is special as determined by either the IsSpecialName property 
        /// or the presence of a compiler-generated character in the method name
        /// </summary>
        /// <param name="src">The method to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNonSpecial(this MethodInfo src)
            => ! src.IsSpecial();

    }
}