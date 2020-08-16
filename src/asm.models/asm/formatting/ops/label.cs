//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct AsmRender
    {
        [MethodImpl(Inline), Op]
        public static string label(FlowControl src)
            => $"flow/{src}";

        /// <summary>
        /// Formats a line label
        /// </summary>
        /// <param name="src">The relative line location</param>
        [MethodImpl(Inline), Op]
        public static string label(ulong src)
            => text.concat(src.FormatSmallHex(), HexFormatSpecs.PostSpec, Space);

        [MethodImpl(Inline), Op]
        public static string label(string text, ulong baseaddress)
            => Parsers.hex().Parse(text).ToOption().Map(address => (address - baseaddress).FormatSmallHex(true),  
                    () => $"{text}?");
    }
}