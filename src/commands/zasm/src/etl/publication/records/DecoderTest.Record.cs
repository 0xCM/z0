//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Linq;

    using Z0.Asm.Data;

    using R = DecoderTestRecord;
    using F = DecoderTestField;

    public readonly struct DecoderTestRecord : IRecord<F,R>
    {
		public int Sequence {get;}

        public readonly int Line;

        public readonly Mnemonic Mnemonic;

        public readonly Code Code;

		public readonly int Bits;

		public readonly bool CanEncode;

		public readonly bool InvalidEOB;

		public readonly string Input;

		public readonly string Encoded;
				
        public readonly Register OpMask;

		public readonly int OpCount;

        public readonly OpKind Op0Kind, Op1Kind, Op2Kind, Op3Kind, Op4Kind;

        public readonly Register Op0Reg, Op1Reg, Op2Reg, Op3Reg, Op4Reg;

		public readonly ulong Address64;

		public readonly ulong NearBranch;

		public readonly uint FarBranch;

		public readonly ushort FBSelector;

		public readonly DecoderOptions DecoderOptions;

		public readonly MemorySize MemSize;

		public readonly Register MemSeg;

		public readonly Register SegPrefix;

		public readonly Register MemBase;

		public readonly Register MemIndex;

		public readonly int MemIndexScale;

		public readonly uint MemDx;

		public readonly int MemDxSize;


        public DecoderTestRecord(
            int Sequence,
            int Line, 
            Mnemonic Mnemonic, 
            Code Code, 
            int Bits, 
            bool CanEncode, 
            bool InvalidEOB, 
            string HexBytes, 
            string EncodedHexBytes, 
            Register OpMask,
            int OpCount,
            OpKind Op0Kind,
            OpKind Op1Kind,
            OpKind Op2Kind,
            OpKind Op3Kind,
            OpKind Op4Kind,
            Register Op0Reg,
            Register Op1Reg,
            Register Op2Reg,
            Register Op3Reg,
            Register Op4Reg,
            ulong Address64,
            ulong NearBranch,
            uint FarBranch,
            ushort FBSelector,
            MemorySize MemSize,
            Register MemSeg,
            Register SegPrefix,
            Register MemBase,
            Register MemIndex,
            int MemIndexScale,
            uint MemDx,
            int MemDxSize,

            DecoderOptions DecoderOptions
            )    
        {
            this.Sequence = Sequence;
            this.Line = Line;
            this.CanEncode = CanEncode;
            this.InvalidEOB = InvalidEOB;
            this.DecoderOptions = DecoderOptions;
            this.Bits = Bits;
            this.Input = HexBytes;
            this.Encoded = EncodedHexBytes;
            this.Code = Code;
            this.Mnemonic = Mnemonic;
            this.OpMask = OpMask;
            this.OpCount = OpCount;
            this.Op0Kind = Op0Kind;
            this.Op1Kind = Op1Kind;
            this.Op2Kind = Op2Kind;
            this.Op3Kind = Op3Kind;
            this.Op4Kind = Op4Kind;
            this.Op0Reg = Op0Reg;
            this.Op1Reg = Op1Reg;
            this.Op2Reg = Op2Reg;
            this.Op3Reg = Op3Reg;
            this.Op4Reg = Op4Reg;
            this.Address64 = Address64;
            this.NearBranch = NearBranch;
            this.FarBranch = FarBranch;
            this.FBSelector = FBSelector;
            this.MemSize = MemSize;
            this.MemSeg = MemSeg;
            this.SegPrefix = SegPrefix;
            this.MemBase = MemBase;
            this.MemIndex = MemIndex;
            this.MemIndexScale = MemIndexScale;
            this.MemDx = MemDx;
            this.MemDxSize = MemDxSize;
        }
    }
}