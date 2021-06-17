//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether a <see cref='C'/> code is within the range [a..f] or the range [A..F]
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool hexletter(C src)
            => hexletter(LowerCase, src) || hexletter(UpperCase, src);

        [MethodImpl(Inline), Op]
        public static bit hexletter(LowerCased @case, C src)
            => between(src, C.a, C.f);

        [MethodImpl(Inline), Op]
        public static bit hexletter(UpperCased @case, C src)
            => between(src,C.A, C.B);

        [MethodImpl(Inline), Op]
        public static bit hexletter(LowerCased @case, char src)
            => between(src, (char)C.a, (char)C.f);

        [MethodImpl(Inline), Op]
        public static bit hexletter(UpperCased @case, char src)
            => between(src, (char)C.A, (char)C.B);

        /// <summary>
        /// Determines whether a <see cref='char'/> is within the range [a..f] or the range [A..F]
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bool hexletter(char src)
            => hexletter(LowerCase, src) || hexletter(UpperCase, src);
   }
}