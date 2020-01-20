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

	using Iced.Intel;
    
    using AsmOpKind = Iced.Intel.OpKind;
    
    using static Iced.Intel.OpKind;
    using static zfunc;
    
    public static class AsmFunction
    {        
        public static AsmFuncInfo decode(INativeMemberData src)
        {            
            var instructions = AsmDecoder.decode(src);
            var count = instructions.InstructionCount;
            var format = instructions.FormatInstructions(AsmFormatConfig.Default.Invert());            
            var dst = new AsmInstructionInfo[count];
            var offset = (ushort)0;
            for(var i=0; i<count; i++)
            {
                dst[i] = instructions[i].SummarizeInstruction(src.Code, format[i], offset);
                offset += (ushort)instructions[i].ByteLength;
            }
            return AsmFuncInfo.Define(src.Location, src.Code, dst);            
        }

        public static IEnumerable<AsmFuncInfo> from(IEnumerable<MethodDisassembly> src)
            => src.Select(from);

        public static AsmFuncInfo from(AsmCodeSet src)
        {
            var instructions = src.Decoded;
            var count = instructions.InstructionCount;
            var format = instructions.FormatInstructions(AsmFormatConfig.Default.Invert());            
            var dst = new AsmInstructionInfo[count];
            var offset = (ushort)0;

            for(var i=0; i<count; i++)
            {
                dst[i] = instructions[i].SummarizeInstruction(src.Encoded, format[i], offset);
                offset += (ushort)instructions[i].ByteLength;

            }
            return AsmFuncInfo.Define(src.Location, src.Encoded, dst);
        }

        public static AsmFuncInfo from(MethodDisassembly src)
        {
            var body = src.AsmBody;
            var instructions = src.Instructions;
            var descriptions = new AsmInstructionInfo[instructions.InstructionCount];
            var format = instructions.FormatInstructions(AsmFormatConfig.Default.Invert());     
            var offset = (ushort)0;

            for(var i=0; i<descriptions.Length; i++)
            {
                descriptions[i] = instructions[i].SummarizeInstruction(src.AsmCode, format[i], offset);
                offset += (ushort)instructions[i].ByteLength;
            }
            
            return AsmFuncInfo.Define(body.Location, 
                AsmCode.Define(src.Id, src.Method.Signature().Format(),body.NativeBlock.Data), descriptions);            
        }
    }
}
