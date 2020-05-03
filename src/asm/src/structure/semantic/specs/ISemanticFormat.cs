//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static FlowControl;
    using static AsmFormatServices;
    using static OpKind;

    public interface ISemanticFormat : 
        IEntitled<FlowControl>, 
        IEntitled<MemorySize>, 
        IFormatter<AsmOperandInfo>,
        IFormatter<Register>,
        IFormatter<AsmMemDirect>,
        IFormatter<AsmMemInfo>,
        IFormatter<AsmImmInfo>
    {
        IFormatter<FlowControl> IEntitled<FlowControl>.ContentFormatter 
            => Formatters.content<FlowControl>(RenderContent);

        ITitleFormatter<FlowControl> IEntitled<FlowControl>.TitleFormatter
            => Formatters.title<FlowControl>(RenderTitle);

        IFormatter<MemorySize> IEntitled<MemorySize>.ContentFormatter 
            => Formatters.content<MemorySize>(RenderContent);

        ITitleFormatter<MemorySize> IEntitled<MemorySize>.TitleFormatter
            => Formatters.title<MemorySize>(RenderTitle);

        string IFormatter<AsmOperandInfo>.Format(AsmOperandInfo src)
            => AsmFormatServices.RenderContent(src);            

        string IFormatter<Register>.Format(Register src)
            => AsmFormatServices.RenderContent(src);            

        string IFormatter<AsmMemDirect>.Format(AsmMemDirect src)
            => AsmFormatServices.RenderContent(src);            

        string IFormatter<AsmMemInfo>.Format(AsmMemInfo src)
            => AsmFormatServices.RenderContent(src);            

        string IFormatter<AsmImmInfo>.Format(AsmImmInfo src)
            => AsmFormatServices.RenderContent(src);            

    }

    readonly struct AsmFormatServices : ISemanticFormat
    {
        public static string RenderContent(AsmMemDirect src)        
            => text.concat(
                src.BaseRegister, 
                (src.IndexScale != 0 && src.IndexScale != 1) ? text.concat(Chars.Plus, src.IndexScale.ToString()) : string.Empty, 
                //src.DisplacementSize != 0 ? text.concat(Chars.Space, src.DisplacementSize) : string.Empty, 
                src.Displacement != 0 ? text.concat(Chars.Plus, src.Displacement.FormatAsmHex()) : string.Empty);

        public static string RenderContent(AsmMemInfo src)        
        {
            var builder = text.build();
            builder.Append(RenderContent(src.Size));
            builder.Append(Chars.Space);
            builder.Append(src.Direct.MapValueOrDefault(x => RenderContent(x), string.Empty));
            builder.Append(Chars.Space);        
            builder.Append(src.SegmentRegister.IsSome() ? text.concat("seg/",RenderContent(src.SegmentRegister)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.SegmentPrefix.IsSome() ? text.concat("prefix/", RenderContent(src.SegmentPrefix)) : string.Empty);
            builder.Append(Chars.Space);        
            builder.Append(src.Address != 0 ? src.Address.FormatAsmHex() : string.Empty);
            return builder.ToString();
        }

        public static string RenderContent(AsmImmInfo src)
            => text.concat(src.Label, Chars.Colon, Chars.Space, src.Value.FormatHex(zpad:false, prespec:false));

        public static string RenderTitle(MemorySize src)
            => "mem";

        public static string RenderContent(MemorySize src)
            => src switch {
                MemorySize.Int8 => "8i",
                MemorySize.Int16 => "16i",
                MemorySize.Int32 => "32i",
                MemorySize.Int64 => "64i",
                MemorySize.UInt8 => "8u",
                MemorySize.UInt16 => "16u",
                MemorySize.UInt32 => "32u",
                MemorySize.UInt64 => "64u",
                _   => src.ToString()
            };

        public static string RenderContent(FlowControl src)
            => src switch{
                Next => "next",
                UnconditionalBranch => "branch/unconditional",
                IndirectBranch => "branch/indirect",
                ConditionalBranch => "branch/conditional",
                Return => "return",
                FlowControl.Exception => "exception",		
                XbeginXabortXend => "XbeginXabortXend",
                Interrupt => "interrupt",
                IndirectCall => "call/indirect",
                Call => "call",
                _ => string.Empty
            };

        public static string RenderTitle(FlowControl src)
            => "flow";

        public static string RenderContent(Register src)
            => src.ToString();

        public static string RenderContent(AsmOperandInfo src)
        {            
            switch(src.Kind)
            {
                case OpKind.Register:
                    return RenderContent(src.Register);
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemorySegDI:
                case MemorySegEDI:
                case MemorySegRDI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                case Memory64:
                case OpKind.Memory:
                    return RenderContent(src.Memory);
                case NearBranch16:
                case NearBranch32:
                case NearBranch64:
                case FarBranch16:
                case FarBranch32:
                    return src.Branch.Format();
                case Immediate8:
                case Immediate8_2nd:
                case Immediate16:
                case Immediate32:
                case Immediate64:
                case Immediate8to16:
                case Immediate8to32:
                case Immediate8to64:
                case Immediate32to64:
                    return RenderContent(src.ImmInfo);
                default:
                    return "missed?";
            }            
        }
    }
}