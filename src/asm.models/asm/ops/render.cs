//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Konst;
    
    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static string render(in AsmState state, in MemDx src)
            => (src.Size switch{
                DataSize.y1 => ((byte)src.Value).FormatHex(state.HexConfig),
                DataSize.y2 => ((ushort)src.Value).FormatHex(state.HexConfig),
                DataSize.y4 => ((uint)src.Value).FormatHex(state.HexConfig),
                _ => (src.Value).FormatHex(state.HexConfig),
            }) + "dx";


        [MethodImpl(Inline), Op]
        public static string render(in ImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));

    }
}