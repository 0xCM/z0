//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct AsmRender
    {
        [MethodImpl(Inline), Op]
        public static string format(AsmFxCode src, in AsmFormatSpec fmt)
            => $"{src.Expression}{fmt.FieldDelimiter}{src.OpCode}";

        [Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src, in AsmFormatSpec config)
        {
            var description = text.build();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(label(src.Offset), src.Formatted.PadRight(config.InstructionPad, Space)));
            description.Append(comment(format(src.Spec, config)));
            description.Append(text.concat(config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHexBytes(Space, true, false)));
            return description.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src)
            => format(@base, src, AsmFormatSpec.Default);

        [Op]
        public static string format(in AsmRoutines src, in AsmFormatSpec config)
        {
            var dst = text.build();
            for(var i=0; i<src.Data.Length; i++)
            {
                dst.Append(lines(src.Data[i], config).Concat());
                dst.AppendLine(text.PageBreak);
            }
            return dst.ToString();
        }
    
        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        [Op]
        public static string format(in AsmRoutine src, in AsmFormatSpec config)
        {            
            var dst = text.build();
            
            if(config.EmitSectionDelimiter)
                dst.AppendLine(config.SectionDelimiter);
            
            if(config.EmitFunctionHeader)        
                foreach(var line in header(src, config))
                    dst.AppendLine(line);            

            dst.AppendLine(lines(src, config).Concat(Chars.Eol));            
            
            return dst.ToString();
        }
    }
}