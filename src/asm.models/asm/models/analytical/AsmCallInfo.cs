//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmCallInfo : IAsmCallInfo
    {
        readonly LocatedAsmFx Instruction;

        public MemoryAddress Target {get;}

        public static string[] AspectNames
            => AsmAspects.Names<IAsmCallInfo>();

        public string[] AspectValues
            => AsmAspects.Values<IAsmCallInfo>(this);
        
        public MemoryAddress Source 
            => Instruction.IP;                

        public MemoryAddress TargetOffset 
            => Target - (Source + InstructionSize);

        public byte InstructionSize 
            => (byte)Instruction.ByteLength;

        public BinaryCode Encoded 
            => Instruction.Encoded;

        [MethodImpl(Inline)]
        public AsmCallInfo(LocatedAsmFx src)
        {
            Instruction = src;
            Target = MemoryAddress.Empty;
            var bytes = z.span(src.Encoded.Data);            
            var count = (byte)(bytes.Length - 1); //op code takes up one byte
            var offset = ByteReader.read(bytes.Slice(1));
            Target = src.NextIp + offset;            
        }        
    }
}