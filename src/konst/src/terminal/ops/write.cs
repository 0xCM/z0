//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System.Runtime.CompilerServices;
     using static Konst;

    partial struct term
    {
        /// <summary>
        /// Writes a single character to the terminal
        /// </summary>
        /// <param name="c">The character to write</param>
        /// <param name="color">The foreground color</param>
        [MethodImpl(Inline)]
        public static void write(char c, FlairKind? color = null)
            => T.WriteChar(c, color ?? FlairKind.Status);
    }
}