//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Z0.Asm;

    public readonly struct MachineCallInfo : IMachineCallInfo
    {
        readonly ApiInstruction Fx;

        public MemoryAddress Source {get;}

        public MemoryAddress Target {get;}

        public MemoryAddress TargetOffset {get;}

        public byte InstructionSize {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public MachineCallInfo(in ApiInstruction src)
        {
            Fx = src;
            Source = src.IP;
            Encoded = src.Encoded;
            InstructionSize = (byte)src.Size;
            var bytes = span(src.EncodedData.Data);
            var count = (byte)(Encoded.Length - 1); //op code takes up one byte
            var offset = ByteRead.read(bytes.Slice(1));
            Target = src.NextIp + offset;
            TargetOffset = Target - (Source + InstructionSize);
        }

        [MethodImpl(Inline)]
        public ref AsmCallRow Fill(ref AsmCallRow dst)
        {
            dst.Encoded = Encoded;
            dst.InstructionSize = (ByteSize)InstructionSize;
            dst.Source = Source;
            dst.Target = Target;
            dst.TargetOffset = TargetOffset;
            return ref dst;
        }
    }
}