//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static OpKind;
    using static Konst;

    public readonly partial struct SemanticRender
    { 
        public static SemanticRender Service => default(SemanticRender);

        public string Render(AsmBranchInfo src)
            => src.Render();
    
        const string Unknown = "???";

        public string Render(Register src)
            => src.ToString();


        public string Render(in ImmInfo src)
            => Z0.asm.render(src);

        public string Render(MemDx src)
            => src.Format();

        public string Render(OpKind src)
        {
            var si = RenderSegKind(src);
            if(text.nonempty(si))
                return si;

            var result = src switch{
		    OpKind.Register => "register",
            NearBranch16 => "branch16",
		    NearBranch32 => "branch32",
		    NearBranch64 => "branch64",
            FarBranch16 => "farbranch16",
            FarBranch32 => "farbranch32",
            Immediate8 => "imm8",
            Immediate8_2nd => "imm8x2",
            Immediate16 => "imm16",
            Immediate32 => "imm32",
            Immediate64 => "imm64",
            Immediate8to16 => "imm16i",
            Immediate8to32 => "imm32i",
            Immediate8to64 => "imm64i",
            Immediate32to64 => "imm32x64i",
            Memory64 => "mem64",
            Memory => "mem",
                _ => src.ToString()
            };

            return result;
        }

        public string Render(MemDirect src)        
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(Render(src.Base));
            else
                dst.Append("UNK");
                
            if(src.Scale.NonUnital && src.Scale.NonZero)
            {
                var scale = Render(src.Scale);
                dst.Append(text.concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(text.concat(Chars.Space, Chars.Plus, Chars.Space, Render(src.Dx)));

            return dst.ToString();
        }

        public string RenderAspects<T>(object src)
            where T : class
                => AsmAspects.From<T>(src).Format();                

        static string RenderSegKind(string symbol)
            => text.blank(symbol) ? EmptyString : text.concat("seg:", Chars.LBracket, symbol, Chars.RBracket);
        
        static string RenderSegKind(OpKind src)
            => RenderSegKind(src switch {
                MemorySegDI => "di",
                MemorySegEDI => "edi",
                MemorySegESI => "esi",
                MemorySegRDI => "rdi",
                MemorySegRSI => "rsi",
                MemorySegSI => "si",
                MemoryESDI => "esdi",
                MemoryESEDI => "esedi",
                MemoryESRDI => "esrdi",
            _ => ""
            });


        public string Render(InstructionMemory src)
            => src.AspectRender;
        
        public string RenderAddress(Instruction src, int pad = 16)
            => text.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        static AsmQuery Q => AsmQuery.Direct;

        public string Render(MemorySize src)
            => Q.Identify(src).Format();

        public string Render(MemInfo src)        
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


        public string Render(MemScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }

    }
}