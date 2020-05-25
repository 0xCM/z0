//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    public interface IAsmDataModel
    {   
        string Name {get;}
    }

    public interface IAsmDataModel<M> : IAsmDataModel
        where M : IAsmDataModel<M>, new()
    {
        string IAsmDataModel.Name => typeof(M).Name;
    }

    public interface IAsmDataModel<M,D> : IAsmDataModel<M>
        where D : unmanaged, Enum
        where M : IAsmDataModel<M,D>, new()
    {
        D Discriminator {get;}        
    }

    public readonly struct AsmDataModel<M> : IAsmDataModel<M>
        where M : unmanaged, IAsmDataModel<M>
    {
        
    }

    public readonly struct AsmDataModel<F,R,M,D>
        where F : unmanaged, Enum
        where R : IRecord
        where M : IAsmDataModel
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
        public readonly struct OpCodeForms : IAsmDataModel<OpCodeForms>
        {            
            public static OpCodeForms Model => default(OpCodeForms);            
        }

        public readonly struct Instructions : IAsmDataModel<Instructions>
        {
            public static Instructions Model => default(Instructions);
        }

        public readonly struct OperandCounts : IAsmDataModel<OperandCounts>
        {
            public static OperandCounts Model => default(OperandCounts);
        }

        public readonly struct DecoderTests16 : IAsmDataModel<DecoderTests16,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit16;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct DecoderTests32 : IAsmDataModel<DecoderTests32,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit32;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct DecoderTests64 : IAsmDataModel<DecoderTests64,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit64;

            public static DecoderTests Model => default(DecoderTests);
        }

        public readonly struct MemoryTests16 : IAsmDataModel<MemoryTests16,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit16;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct MemoryTests32 : IAsmDataModel<MemoryTests32,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit32;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct MemoryTests64 : IAsmDataModel<MemoryTests64,TestCaseBits>
        {
            public TestCaseBits Discriminator => TestCaseBits.Bit64;

            public static MemoryTests Model => default(MemoryTests);
        }

        public readonly struct DecoderTests : IAsmDataModel<DecoderTests>
        {
            public static DecoderTests Model => default(DecoderTests);            

            public static DecoderTests16 Model16 => default(DecoderTests16);

            public static DecoderTests32 Model32 => default(DecoderTests32);

            public static DecoderTests64 Model64 => default(DecoderTests64);

        }

        public readonly struct MemoryTests : IAsmDataModel<MemoryTests>
        {
            public static MemoryTests Model => default(MemoryTests);            

            public static MemoryTests16 Model16 => default(MemoryTests16);

            public static MemoryTests32 Model32 => default(MemoryTests32);

            public static MemoryTests64 Model64 => default(MemoryTests64);
        }


        public readonly struct OpCodeSpecs : IAsmDataModel<OpCodeSpecs>
        {
            public static OpCodeSpecs Model => default(OpCodeSpecs);
        }        
    }
}