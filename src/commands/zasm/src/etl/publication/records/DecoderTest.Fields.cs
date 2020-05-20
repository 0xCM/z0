//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;

    using I = DecoderTestFieldId;
    using W = DecoderTestFieldWidth;
    using R = RecordFields;
    using RW = RecordFieldWidths;

    public enum DecoderTestFieldEmit : uint
    {
        Sequence = R.Include,  Mnemonic = R.Include, OpCode = R.Include,  Ops = R.Include, 
        
        Op0 = R.Include, Op0K = Op0, Op0R = Op0, 
        
        Op1 = R.Include, Op1K = Op1, Op1R = Op1, 
        
        Op2 = R.Include, Op2K = Op2, Op2R = Op2, 
        
        Op3 = R.Include, Op3K = Op3, Op3R = Op3, 
        
        Op4 = R.Include, Op4K = Op4, Op4R = Op4,

        HexRef = R.Include, HexEnc = R.Include, 
        
        BitMode = R.Include,  CanEnc = R.Include, InvEob = R.Include, OpMask = R.Include,  
        
        Address64 = R.Include, NearBranch = R.Include, FarBranch = R.Include,  FBSelector = R.Include,
        
        MemSize = R.Include, MemSeg = R.Include, SegPrefix = R.Include, MemBase = R.Include, 
        MemIndex = R.Include, MemIndexScale = R.Include, MemDx = R.Include, MemDxSize = R.Include,
        
        Line = R.Include,  Id = R.Include,   DecoderOptions = R.Include,
    }
    
    public enum DecoderTestFieldId
    {
        Sequence,  Mnemonic, OpCode,  Ops, 
        
        Op0K, Op0R, 
        
        Op1K, Op1R, 
        
        Op2K, Op2R, 
        
        Op3K, Op3R, 
        
        Op4K, Op4R,

        HexRef, HexEnc, 
        
        BitMode,  CanEnc, InvEob, OpMask,  
        
        Address64, NearBranch, FarBranch,  FBSelector,
        
        MemSize, MemSeg, SegPrefix, MemBase, MemIndex, MemIndexScale, MemDx, MemDxSize,
        
        Line,  Id,   DecoderOptions,
    }

    public enum DecoderTestFieldWidth
    {
		Line = 8, 

        OpMask = 12,

        MemWidths = 16,
    
        Address64 = MemWidths, 
        
        NearBranch = 12, 
        
        FarBranch = MemWidths, 
        
        FBSelector = 12,
        
        MemSize = MemWidths, 
        
        MemSeg = MemWidths, 
        
        SegPrefix = MemWidths, 
                
        MemBase = MemWidths, 
        
        MemIndex = MemWidths, 
        
        MemIndexScale = MemWidths, 
        
        MemDx = MemWidths, 
        
        MemDxSize = MemWidths,
 
        DecoderOptions = 8,
    }

    /// <summary>
    /// Defines the fields collected by <see cref='DecoderTestRecord'/>
    /// </summary>
    public enum DecoderTestField : uint
    {
        /// <summary>
        /// The record sequence number
        /// </summary>
		Sequence = I.Sequence | RW.Sequence << RW.Offset,
        
        /// <summary>
        /// The instruction mnemonic
        /// </summary>
        Mnemonic = I.Mnemonic | RW.Mnemonic << RW.Offset,

        /// <summary>
        /// The instruction op code
        /// </summary>
        OpCode = I.OpCode | RW.OpCode << RW.Offset,

        /// <summary>
        /// The number of encoded operands 
        /// </summary>
		Ops = I.Ops | RW.Num8Dec << RW.Offset,

        /// <summary>
        /// The Ops[0] kind classifier, if any
        /// </summary>
        Op0K = I.Op0K | RW.OpKind << RW.Offset,

        /// <summary>
        /// The Ops[0] register operand, if any
        /// </summary>
        Op0R = I.Op0R | RW.Register << RW.Offset,

        /// <summary>
        /// The Ops[1] kind classifier, if any
        /// </summary>
        Op1K = I.Op1K | RW.OpKind << RW.Offset,
        
        /// <summary>
        /// The Ops[1] register operand, if any
        /// </summary>
        Op1R = I.Op1R | RW.Register << RW.Offset,

        /// <summary>
        /// The Ops[2] kind classifier, if any
        /// </summary>
        Op2K = I.Op2K | RW.OpKind << RW.Offset,

        /// <summary>
        /// The Ops[2] register operand, if any
        /// </summary>
        Op2R = I.Op2R | RW.Register << RW.Offset,

        /// <summary>
        /// The Ops[3] kind classifier, if any
        /// </summary>
        Op3K = I.Op3K | RW.OpKind << RW.Offset,
        
        /// <summary>
        /// The Ops[3] register operand, if any
        /// </summary>
        Op3R = I.Op3R | RW.Register << RW.Offset,

        /// <summary>
        /// The Ops[4] kind classifier, if any
        /// </summary>
        Op4K = I.Op4K | RW.OpKind << RW.Offset,

        /// <summary>
        /// The Ops[4] register operand, if any
        /// </summary>
        Op4R = I.Op4R | RW.Register << RW.Offset,

        /// <summary>
        /// Reference encoding
        /// </summary>
		HexRef = I.HexRef | RW.Enc << RW.Offset,        

        /// <summary>
        /// Result encoding
        /// </summary>
		HexEnc = I.HexEnc | RW.Enc << RW.Offset,

        /// <summary>
        /// The encoding bitness: 16/32/64
        /// </summary>
		BitMode = I.BitMode | RW.Num8Dec << RW.Offset,

        /// <summary>
        /// Can encode?
        /// </summary>
		CanEnc = I.CanEnc | RW.Boolean << RW.Offset,

        /// <summary>
        /// Invalid End Of Bytes
        /// </summary>
		InvEob = I.InvEob | RW.Boolean << RW.Offset,

		OpMask = I.OpMask | W.OpMask << RW.Offset,
                     
        Address64 = I.Address64 | W.Address64 << RW.Offset,
        
        NearBranch = I.NearBranch | W.NearBranch<< RW.Offset,
        
        FarBranch = I.FarBranch | W.FarBranch << RW.Offset,
        
        FBSelector = I.FBSelector | W.FBSelector << RW.Offset,

        MemSize = I.MemSize | W.MemSize << RW.Offset,
        
        MemSeg = I.MemSeg | W.MemSeg << RW.Offset,
        
        SegPrefix = I.SegPrefix | W.SegPrefix << RW.Offset,
        
        MemBase  = I.MemBase | W.MemBase << RW.Offset,
        
        MemIndex = I.MemIndex | W.MemIndex << RW.Offset,
        
        MemIndexScale = I.MemIndexScale | W.MemIndexScale << RW.Offset,
        
        MemDx = I.MemDx | W.MemDx << RW.Offset,
        
        MemDxSize  = I.MemSize | W.MemSize << RW.Offset,

        /// <summary>
        /// The line of the source file from which the record was extracted
        /// </summary>
        Line = I.Line | W.Line << RW.Offset,

        /// <summary>
        /// The op code identifier
        /// </summary>
        Id = I.Id | RW.Id << RW.Offset,
 
        DecoderOptions = I.DecoderOptions | W.DecoderOptions << RW.Offset,
    }
}