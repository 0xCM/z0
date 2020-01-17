//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class AsmFormat
    {
        const string BeginComment = "; ";

        const int IPad = 40;

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="pad">The padding between each instruction and associated commentary</param>
        public static string FormatDetail(this AsmFuncInfo src, bool encoding = true,  bool location = false, bool timestamp = true)
            => lines(src.FormatHeader(encoding, location, timestamp),  src.FormatInstructions(IPad));                

        /// <summary>
        /// Formats the function body encoding as a comma-separated list of hex values
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatEncoded(this AsmFuncInfo src)
            => src.Code.Data.FormatHex(AsciSym.Comma, true, true, true);

        /// <summary>
        /// Formats a single operand
        /// </summary>
        /// <param name="src">The source operand</param>
        static string Format(this AsmOperandInfo src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatHex(false,true,false,false)}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r.RegisterName, () => string.Empty);
            fmt += src.Memory.Map(r => r.Format(), () => string.Empty);
            fmt += src.Branch.Map(b => b.Format(), () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind;
            return fmt;   
        }

        /// <summary>
        /// Formats the operands contained in an instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        static string FormatOperands(this AsmInstructionInfo src)
        {
            var count = src.Operands.Length;
            if(count == 0)
                return string.Empty;

            var sb = text();   
            for(var i=0; i<src.Operands.Length; i++)
            {
                sb.Append(src.Operands[i].Format());
                if(i != src.Operands.Length - 1)
                    sb.Append(AsciSym.Comma);                            
            }
            return bracket(sb.ToString());
        }

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="pad">The minimum character width of the instruction content</param>
        static string Format(this AsmInstructionInfo src, int pad)
        {
            var address = src.Offset.FormatHex(true,true,false,false);
            var content = src.Display.PadRight(pad, AsciSym.Space);
            var encodingKind = !string.IsNullOrWhiteSpace(src.EncodingKind) ? $"{src.EncodingKind}, " : string.Empty;
            var encodingLen = concat(
                    src.Encoding.Length.ToString(), 
                    AsciSym.Space, 
                    src.Encoding.Length > 1 ?  "bytes" : "byte "
                    );
            var encoding = $" encoding({encodingKind}{encodingLen}) = " + src.Encoding.FormatHex(AsciSym.Space, true, false);
            var operands = src.FormatOperands();
            var title = concat(src.Mnemonic, AsciSym.LParen, src.OpCode, AsciSym.RParen);
            return (address + AsciSym.Space + content + "; " + title + " " + operands).PadRight(90, AsciSym.Space) + encoding;
        }
        
        static string FormatInstructions(this AsmFuncInfo src, int pad)
        {
            var format = text();            
            for(var i = 0; i< src.InstructionCount; i++)
            {
                var insx = src.Instructions[i];
                var fmt = insx.Format(pad);
                if(i != src.InstructionCount - 1)
                    format.AppendLine(fmt);
                else
                    format.Append(fmt);
            }
            return format.ToString();
        }    

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="encoding">Specifies whether to include the encoded hex bytes</param>
        /// <param name="location">Specifies whether to include the assembly-relative function location address</param>
        static string FormatHeader(this AsmFuncInfo src, bool encoding = true,  bool location = false, bool timestamp = true)
        {            
            var header = line(concat(BeginComment, $"{src.Code.Label}")); 
            if(encoding)           
                header += line(src.FormatEncodingProp());
            if(location)
                header += line(concat(BeginComment, $"{src.StartAddress.AddressRange(src.EndAddress)}, {src.EndAddress - src.StartAddress} bytes"));
            if(timestamp)
                header += concat(BeginComment, now().ToLexicalString());
            return header;
        }

        /// <summary>
        /// Formats the encoded bytes as a comment
        /// </summary>
        /// <param name="src">The source function</param>
        static string FormatEncodingProp(this AsmFuncInfo src)
        {
            var propdecl = $"static ReadOnlySpan<byte> {src.Name}Bytes";
            return concat(BeginComment, $"{propdecl} => new byte[{src.Code.Data.Length}]", embrace(src.FormatEncoded()), AsciSym.Semicolon);              
        }

        static string HexFormat(this ulong src)
            => src.FormatHex(false,true,true,false);

        static string AddressRange(this ulong start, ulong end)
            => bracket(concat(start.HexFormat(), AsciSym.Space, AsciSym.Colon, AsciSym.Space, end.HexFormat()));

        static string Format(this AsmBranchInfo src)
        {
            var target = src.Near ? src.Target - src.Base : src.Target;
            return $"{target.HexFormat()}:{src.Label}";
        }

        static string Format(this AsmMemInfo src)
        {
            var items = new List<(string value, string type)>();
            
            if(src.Address != 0)
                items.Add((src.Address.FormatHex(false,true, false, false),"address"));
            
            if(src.Size != string.Empty)
                items.Add((src.Size, string.Empty));
            if(!string.IsNullOrWhiteSpace(src.BaseRegister))
                items.Add((src.BaseRegister,"br"));
            if(!string.IsNullOrWhiteSpace(src.SegmentPrefix))
                items.Add((src.SegmentPrefix,""));
            if(!string.IsNullOrWhiteSpace(src.SegmentRegister))
                items.Add((src.SegmentPrefix,"sr"));

            var sb = text();
            for(var i=0; i<items.Count; i++)
            {
                var item = items[i];
                if(item.type == string.Empty)
                    sb.Append(item.value);
                else
                    sb.Append($"{item.value}:{item.type}");
                if(i != items.Count - 1)
                    sb.Append(AsciSym.Comma);
            
            }
            return "mem" + parenthetical(sb.ToString());
        }
    }
}