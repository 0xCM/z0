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

            var nonempty = false;
            if(!src.IsEmpty)
            {
                var s = Render(src.Direct);
                if(text.nonempty(s))
                {
                    builder.Append(s);
                    nonempty = true;
                }
            }

            if(src.Address.IsNonEmpty)
            {
                builder.Append(src.Address.Format());
                nonempty = true;
            }

            if(src.HasKnownSize && nonempty)
            {
                builder.Append(Chars.Colon);
                builder.Append(Render(src.Size));
            }
            
            return builder.ToString();
        }
    }
}