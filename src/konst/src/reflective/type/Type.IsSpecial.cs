//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class XTend
    {
        static ReadOnlySpan<char> SpecialChars => new char[]{'<','>','|'};

        /// <summary>
        /// Determines whether a method is non-special as determined by either the IsSpecialName property 
        /// or the presence of a compiler-generated character in the method name
        /// </summary>
        /// <param name="src">The method to examine</param>
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