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

    public enum DecoderTestFieldId
    {
        Sequence,  Line,  Mnemonic,  
        
        OpCode,  HexInput, HexEncoded, 
        Bitness,  CanEncode, InvalidEOB, OpMask,  OpCount, 
        
        Op0Kind, Op1Kind, Op2Kind, Op3Kind, Op4Kind,

        Op0Reg, Op1Reg, Op2Reg, Op3Reg, Op4Reg,

        Address64, NearBranch, FarBranch,  FBSelector,
        
        MemSize, MemSeg, SegPrefix, MemBase, MemIndex, MemIndexScale, MemDx, MemDxSize,
        
        Id,   

        DecoderOptions,
    }

    public enum DecoderTestFieldWidth
    {
		Sequence = RW.Sequence,  Line = 8, Mnemonic = 12,

		OpCode = RW.OpCode, HexInput = RW.DataWidth, HexEncoded = RW.DataWidth, 

		Bitness = 8, CanEncode = 12, InvalidEOB = 12,

        OpMask = 12, Operands = 12, 

        OpKindWidth = 14, MemWidths = 16,

        Op0Kind = OpKindWidth, Op1Kind = OpKindWidth, Op2Kind = OpKindWidth, Op3Kind = OpKindWidth, Op4Kind = OpKindWidth,

        Op0Reg = RW.Register, Op1Reg = RW.Register, Op2Reg = RW.Register, Op3Reg = RW.Register, Op4Reg = RW.Register,

        Address64 = MemWidths, NearBranch = 12, FarBranch = MemWidths, FBSelector = 12,
        
        MemSize = MemWidths, MemSeg = MemWidths, SegPrefix = MemWidths, MemBase = MemWidths, 
        
        MemIndex = MemWidths, MemIndexScale = MemWidths, MemDx = MemWidths, MemDxSize = MemWidths,

        Id = RW.Id,
 
        DecoderOptions = 8,

    }

    public enum DecoderTestField
    {
		Sequence = I.Sequence | W.Sequence << RW.Offset,
        
        Line = I.Line | W.Line << RW.Offset,

        Mnemonic = I.Mnemonic | W.Mnemonic << RW.Offset,

        OpCode = I.OpCode | RW.OpCode << RW.Offset,

		HexInput = I.HexInput | W.HexInput << RW.Offset,        

		HexEncoded = I.HexEncoded | W.HexEncoded << RW.Offset,

		Bits = I.Bitness | W.Bitness << RW.Offset,

		CanEncode = I.CanEncode | W.CanEncode << RW.Offset,

		InvalidEOB = I.InvalidEOB | W.InvalidEOB << RW.Offset,

		OpMask = I.OpMask | W.OpMask << RW.Offset,

		Operands = I.OpCount | W.Operands << RW.Offset,

        Op0Kind = I.Op0Kind | W.Op0Kind << RW.Offset,

        Op0Reg = I.Op0Reg | W.Op0Reg << RW.Offset,

        Op1Kind = I.Op1Kind | W.Op1Kind << RW.Offset,
        
        Op1Reg = I.Op1Reg | W.Op1Reg << RW.Offset,

        Op2Kind = I.Op2Kind | W.Op2Kind << RW.Offset,

        Op2Reg = I.Op2Reg | W.Op2Reg << RW.Offset,

        Op3Kind = I.Op3Kind | W.Op3Kind << RW.Offset,
        
        Op3Reg = I.Op3Reg | W.Op3Reg << RW.Offset,

        Op4Kind = I.Op4Kind | W.Op4Kind << RW.Offset,

        Op4Reg = I.Op4Reg | W.Op4Reg << RW.Offset,
                     
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

        Id = I.Id | W.Id << RW.Offset,

        DecoderOptions = I.DecoderOptions | W.DecoderOptions << RW.Offset,
    }
}