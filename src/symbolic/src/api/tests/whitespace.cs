//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public partial class SymTest
    {
        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsSpace(char c)
            => (ushort)AsciCharCode.Space == (ushort)c;

        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsTab(char c)
            => (ushort)AsciCharCode.Tab == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool IsNewLine(char c)
            => (ushort)AsciCharCode.NewLine == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool IsLineFeed(char c)
            => (ushort)AsciCharCode.LineFeed == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool IsWhiteSpace(char c)
            => IsSpace(c) || IsTab(c) || IsNewLine(c) || IsLineFeed(c);
    }
}