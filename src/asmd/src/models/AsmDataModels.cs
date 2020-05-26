//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct AsmDataModel<M> : IDataModel<M>
        where M : unmanaged, IDataModel<M>
    {
        
    }

    public readonly struct AsmDataModel<F,R,M,D>
        where F : unmanaged, Enum
        where R : IRecord
        where M : IDataModel
        where D : unmanaged, Enum
    {
        public D Discriminator {get;}                
    }

    public enum TestCaseBits : byte
    {
        None = 0,

        Bit16,

        Bit32,

        Bit64
    }

    public class AsmDataModels
    {
        public readonly struct OpCodeForms : IDataModel<OpCodeForms>
        {            
            public static OpCodeForms Model => default(OpCodeForms);            
        }

        public readonly struct Instructions : IDataModel<Instructions>
        {
            public static Instructions Model => default(Instructions);
        }

        public readonly struct OperandCounts : IDataModel<OperandCounts>
        {
            public static OperandCounts Model => default(OperandCounts);
        }

        public readonly struct DecoderTests16 : IDataModel<DecoderTests16,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit16;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct DecoderTests32 : IDataModel<DecoderTests32,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit32;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct DecoderTests64 : IDataModel<DecoderTests64,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit64;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct MemoryTests16 : IDataModel<MemoryTests16,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit16;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct MemoryTests32 : IDataModel<MemoryTests32,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit32;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct MemoryTests64 : IDataModel<MemoryTests64,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit64;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct DecoderTests : IDataModel<DecoderTests>
        {
            public static DecoderTests Model => default(DecoderTests);            

            public static DecoderTests16 Model16 => default(DecoderTests16);

            public static DecoderTests32 Model32 => default(DecoderTests32);

            public static DecoderTests64 Model64 => default(DecoderTests64);

        }

        public readonly struct MemoryTests : IDataModel<MemoryTests>
        {
            public static MemoryTests Model => default(MemoryTests);            

            public static MemoryTests16 Model16 => default(MemoryTests16);

            public static MemoryTests32 Model32 => default(MemoryTests32);

            public static MemoryTests64 Model64 => default(MemoryTests64);
        }

        public readonly struct OpCodeSpecs : IDataModel<OpCodeSpecs>
        {
            public static OpCodeSpecs Model => default(OpCodeSpecs);
        }        
    }
}