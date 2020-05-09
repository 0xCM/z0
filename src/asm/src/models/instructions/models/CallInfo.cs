//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static AspectLabels;

    public interface ICallInfo
    {                
        MemoryAddress Source {get;}

        MemoryAddress Target {get;}

        byte InstructionSize {get;}

        MemoryAddress TargetOffset {get;}

        BinaryCode Encoded {get;}        
    }

    public readonly struct CallInfo : ICallInfo
    {
        public static string[] AspectNames
            => Aspects.Names<ICallInfo>();

        public string[] AspectValues
            => Aspects.Values<ICallInfo>(this);
        
        readonly LocatedInstruction Instruction;

        public MemoryAddress Target {get;}

        public MemoryAddress Source 
            => Instruction.IP;                

        public MemoryAddress TargetOffset 
            => Target - (Source + InstructionSize);

        public byte InstructionSize 
            => (byte)Instruction.ByteLength;

        public BinaryCode Encoded 
            => Instruction.Encoded;
        
        [MethodImpl(Inline)]
        internal CallInfo(LocatedInstruction src)
        {
            Instruction = src;
            Target = MemoryAddress.Empty;
            var bytes = src.Encoded.Bytes;            
            var length = bytes.Length - 1; //op code takes up one byte
            var dstlen = math.min(8, length);

            if(dstlen != 0)
            {
                var offset = 0ul;
                for(var i=1; i<dstlen; i++)
                    refs.seek8(ref offset, i - 1) = refs.skip(bytes,i);
                Target = src.NextIp + offset;
            }
        }        
    }
}