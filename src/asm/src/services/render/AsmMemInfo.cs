//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static OpKind;

    partial struct SemanticRender
    {
        public static string RenderAddress(Instruction src, int pad = 16)
            => text.concat(src.IP.FormatHex(zpad:false)).PadRight(pad);

        public string RenderSegIndicator(OpKind src)
            => SegIndicator.From(src).Format();

        static AsmQuery Q => AsmQuery.Direct;

        public static string Render(MemorySize src)
            => Q.Identify(src).Format();

        public static string Render(AsmMemInfo src)        
        {
            var builder = text.build();

            var sep = text.concat(Chars.Space, Chars.Pipe, Chars.Space);
            builder.Append(src.Direct.MapValueOrDefault(x => Render(x), string.Empty));
            //builder.Append(Chars.Space);        
            //builder.Append(src.SegmentRegister.IsSome() ? text.concat(sep, "seg/",Render(src.SegmentRegister)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.SegmentPrefix.IsSome() ? text.concat(sep, "prefix/", Render(src.SegmentPrefix)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.Address.NonZero ? src.Address.Format() : string.Empty);

            if(src.HasKnownSize)
            {
                var fmt = Render(src.Size);
                
                builder.Append(sep);
                builder.Append(fmt);
            }
            
            return builder.ToString();
        }
    }
}