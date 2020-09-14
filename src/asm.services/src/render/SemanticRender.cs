//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static OpKind;
    using static Konst;

    [ApiHost]
    public readonly struct SemanticRender
    {
        public static SemanticRender Service => default(SemanticRender);

        public static string label(in AsmBranchTarget src)
            => format(src.Kind, src.Size);

        public static string format(in AsmBranchTarget src)
        {
            var address = src.TargetAddress.FormatMinimal();
            return label(src) + (src.IsNear ? text.bracket(address) : text.bracket(text.concat(address, Chars.Colon, src.Selector.FormatAsmHex())));
        }

        [MethodImpl(Inline), Op]
        public static string format(BranchTargetSize src)
            => src == 0 ? string.Empty : ((byte)src).ToString();

        [MethodImpl(Inline), Op]
        public static string format(BranchTargetKind src, BranchTargetSize sz)
            => src == 0 ? string.Empty : text.concat(src.ToString().ToLower(), format(sz));

        public string Render(AsmBranchInfo src)
            => text.concat(src.Source.Format(), " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        [MethodImpl(Inline), Op]
        public static string render(in HexFormatConfig config, in MemDx src)
            => (src.Size switch{
                MemDxSize.y1 => ((byte)src.Value).FormatHex(config),
                MemDxSize.y2 => ((ushort)src.Value).FormatHex(config),
                MemDxSize.y4 => ((uint)src.Value).FormatHex(config),
                _ => (src.Value).FormatHex(config),
            }) + "dx";

        static HexFormatConfig HexSpec
            => FormatOptions.hex(zpad:false, specifier:false);

        public static string format(in MemDx src)
            => (src.Size switch{
                MemDxSize.y1 => ((byte)src.Value).FormatHex(HexSpec),
                MemDxSize.y2 => ((ushort)src.Value).FormatHex(HexSpec),
                MemDxSize.y4 => ((uint)src.Value).FormatHex(HexSpec),
                _ => (src.Value).FormatHex(HexSpec),
            }) + "dx";

        [MethodImpl(Inline), Op]
        public static string format(in ImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));

        public string Render(IceRegister src)
            => text.format("{0}",src);

        [MethodImpl(Inline), Op]
        public string Render(in ImmInfo src)
            => format(src);

        public string Render(MemDx src)
            => format(src);

        public static string format(OpKind src)
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

        public string Render(OpKind src)
            => format(src);

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
                => Aspects.From<T>(src).Format();

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


        public string Render(AsmFxMemory src)
            => SemanticRender.Service.RenderAspects<IAsmFxMemory>(src);

        public string RenderAddress(Instruction src, int pad = 16)
            => text.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        public string Render(MemorySize src)
            => asm.identify(src).Format();

        [Op]
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

        [MethodImpl(Inline), Op]
        public string Render(MemScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }
    }
}