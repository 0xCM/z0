//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CallInfo : ICallInfo
    {
        readonly LocatedInstruction Instruction;

        public MemoryAddress Target {get;}

        public static string[] AspectNames
            => Aspects.Names<ICallInfo>();

        public string[] AspectValues
            => Aspects.Values<ICallInfo>(this);
        
        public MemoryAddress Source 
            => Instruction.IP;                

        public MemoryAddress TargetOffset 
            => Target - (Source + InstructionSize);

        public byte InstructionSize 
            => (byte)Instruction.ByteLength;

        public BinaryCode Encoded 
            => Instruction.Encoded;

        [MethodImpl(Inline)]
        public CallInfo(LocatedInstruction src)
        {
            Instruction = src;
            Target = MemoryAddress.Empty;
            var bytes = Root.span(src.Encoded.Data);            
            var count = (byte)(bytes.Length - 1); //op code takes up one byte
            var offset = ByteReader.read(bytes.Slice(1));
            Target = src.NextIp + offset;            
        }        
    }
}