//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmFormatServices
    {
        public static string Format(AsmMemInfo src)        
        {
            var builder = text.build();

            var sep = text.concat(Chars.Space, Chars.Pipe, Chars.Space);
            builder.Append(src.Direct.MapValueOrDefault(x => Format(x), string.Empty));
            builder.Append(Chars.Space);        
            builder.Append(src.SegmentRegister.IsSome() ? text.concat(sep, "seg/",Format(src.SegmentRegister)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.SegmentPrefix.IsSome() ? text.concat(sep, "prefix/", Format(src.SegmentPrefix)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.Address != 0 ? src.Address.FormatAsmHex() : string.Empty);

            if(src.HasKnownSize)
            {
                builder.Append(sep);
                builder.Append(RenderContent(src.Size));
            }
            
            return builder.ToString();
        }
    }
}