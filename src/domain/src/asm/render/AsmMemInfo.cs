//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SemanticRender
    {
        public string Render(InstructionMemory src)
            => src.AspectRender;
        
        public string RenderAddress(Instruction src, int pad = 16)
            => text.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        static AsmQuery Q => AsmQuery.Direct;

        public string Render(MemorySize src)
            => Q.Identify(src).Format();

        public string Render(AsmMemInfo src)        
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