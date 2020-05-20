//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Z0.Asm.Data;
    using static Asm.Data.OpKind;

    using R = DecoderTestRecord;
    using F = DecoderTestField;

    public readonly struct DecoderTestRecord : IRecord<F,R>
    {
		public int Sequence {get;}

        public readonly int Line;

        public readonly Mnemonic Mnemonic;

        public readonly OpCodeId Id;

		public readonly int BitMode;

		public readonly bool CanEnc;

		public readonly bool InvEob;

		public readonly string OpCode;

		public readonly string HexRef;

		public readonly string HexEnc;
				
        public readonly Register OpMask;

		public readonly int Ops;

        public readonly OpKind Op0K, Op1K, Op2K, Op3K, Op4K;

        public readonly Register Op0R, Op1R, Op2R, Op3R, Op4R;

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
            Mnemonic Mnemonic, 
            string OpCode,            
            int Ops,

            OpKind Op0K,
            Register Op0R,
            
            OpKind Op1K,
            Register Op1R,
            
            OpKind Op2K,
            Register Op2R,
            
            OpKind Op3K,
            Register Op3R,
            
            OpKind Op4K,
            Register Op4R,
            
            string HexRef, 
            string HexEnc, 
            
            Register OpMask,
            int BitMode, 
            bool CanEnc, 
            bool InvEob, 
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
            int Line, 
            OpCodeId Id, 
            DecoderOptions DecoderOptions
            )    
        {
            this.Sequence = Sequence;
            this.Line = Line;
            this.OpCode = OpCode;
            this.Ops = Ops;
            this.Op0K = Op0K;
            this.Op1K = Op1K;
            this.Op2K = Op2K;
            this.Op3K = Op3K;
            this.Op4K = Op4K;
            this.Op0R = Op0R;
            this.Op1R = Op1R;
            this.Op2R = Op2R;
            this.Op3R = Op3R;
            this.Op4R = Op4R;
            this.HexRef = HexRef;
            this.HexEnc = HexEnc;
            this.Mnemonic = Mnemonic;
            this.OpMask = OpMask;
            this.CanEnc = CanEnc;
            this.InvEob = InvEob;
            this.BitMode = BitMode;
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
            this.Id = Id;
            this.DecoderOptions = DecoderOptions;
        }
    }
}