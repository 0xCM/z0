//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciCode;

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static bit eol(byte a0, byte a1)
            => (C)a0 == CR && (C)a1 == LF;

        [MethodImpl(Inline), Op]
        public static bit eol(char a, char b)
            => cr(a) && lf(b);

        [MethodImpl(Inline), Op]
        public static bit eol(C a0, C a1)
            => a0 == CR && a1 == LF;

        [MethodImpl(Inline), Op]
        public static bit eol(AsciSymbol a0, AsciSymbol a1)
            => a0 == CR && a1 == LF;

        /// <summary>
        /// Returns true if source matches either a <see cref='CR'/> or <see cref='LF'/>
        /// </summary>
        /// <param name="src">The character to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bit eol(byte src)
            => cr((C)src) || lf((C)src);

        /// <summary>
        /// Returns true if source matches either a <see cref='CR'/> or <see cref='LF'/>
        /// </summary>
        /// <param name="src">The code to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bit eol(C src)
            => cr(src) || lf(src);

        /// <summary>
        /// Returns true if source matches either a <see cref='CR'/> or <see cref='LF'/>
        /// </summary>
        /// <param name="src">The character to evaluate</param>
        [MethodImpl(Inline), Op]
        public static bit eol(char src)
            => cr(src) || lf(src);
    }
}