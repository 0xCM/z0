//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct SemanticRender
    {
        public static string Render(AsmMemScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }

        public static string Render(AsmMemDx src)
            => src.Size switch{
                NumericSize.SZ1 => ((byte)src.Value).FormatAsmHex(),
                NumericSize.SZ2 => ((ushort)src.Value).FormatAsmHex(),
                NumericSize.SZ4 => ((uint)src.Value).FormatAsmHex(),
                NumericSize.SZ8 => (src.Value).FormatAsmHex(),
                _ => "0"
            };
    }
}