//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IAsmCallInfo
    {
        MemoryAddress Source {get;}

        MemoryAddress Target {get;}

        byte InstructionSize {get;}

        MemoryAddress TargetOffset {get;}

        BinaryCode Encoded {get;}
    }

    public readonly struct AsmCallInfo : IAsmCallInfo
    {
        readonly ApiInstruction Fx;

        public MemoryAddress Target {get;}

        public static string[] AspectNames
            => Aspects.Names<IAsmCallInfo>();

        public string[] AspectValues
            => Aspects.Values<IAsmCallInfo>(this);

        public MemoryAddress Source
            => Fx.IP;

        public MemoryAddress TargetOffset
            => Target - (Source + InstructionSize);

        public byte InstructionSize
            => (byte)Fx.Size;

        public BinaryCode Encoded
            => Fx.EncodedData;

        [MethodImpl(Inline)]
        public AsmCallInfo(in ApiInstruction src)
        {
            Fx = src;
            Target = MemoryAddress.Empty;
            var bytes = z.span(src.EncodedData.Data);
            var count = (byte)(bytes.Length - 1); //op code takes up one byte
            var offset = ByteRead.read(bytes.Slice(1));
            Target = src.NextIp + offset;
        }

        [MethodImpl(Inline)]
        public ref AsmCallRecord Fill(ref AsmCallRecord dst)
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