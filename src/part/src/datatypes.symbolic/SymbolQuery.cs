//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using AC = AsciCharCode;

    [ApiHost(ApiNames.SymbolQuery, true)]
    public readonly struct SymbolQuery
    {
        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(char c)
            => (ushort)AC.Space == (ushort)c;

        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool tab(char c)
            => (ushort)AC.Tab == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool nl(char c)
            => (ushort)AC.NL == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool cr(char c)
            => (ushort)AC.CR == (ushort)c;

        /// <summary>
        /// Tests whether a character is designated as whitespace
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool whitespace(char c)
            => space(c) || tab(c) || nl(c) || cr(c);
    }
}