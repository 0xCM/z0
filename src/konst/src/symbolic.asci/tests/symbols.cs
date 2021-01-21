//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = AsciCharCode;

    partial struct AsciTest
    {
        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.LBracket'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lbracket(C src)
            => src == C.LBracket;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.LBracket'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lbracket(char src)
            => lbracket((C)src);

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.RBracket'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit rbracket(C src)
            => src == C.RBracket;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.RBracket'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit rbracket(char src)
            => rbracket((C)src);

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.LBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lbrace(C src)
            => src == C.LBrace;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.LBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit lbrace(char src)
            => lbrace((C)src);

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit rbrace(C src)
            => src == C.RBrace;

        /// <summary>
        /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit rbrace(char src)
            => rbrace((C)src);
    }
}