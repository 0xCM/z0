//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Linq;

    using Z0.Asm.Data;

    using I = DecoderTestFieldId;
    using W = DecoderTestFieldWidth;

    public enum DecoderTestFieldId
    {
        Sequence,

		Line,

        Mnemonic,

        Code,

		Bitness,

		CanEncode,

		InvalidEOB,

		HexExpect, HexActual,
				
        OpMask,

		OpCount, Op0Kind, Op1Kind, Op2Kind, Op3Kind, Op4Kind,

        Op0Reg, Op1Reg, Op2Reg, Op3Reg, Op4Reg,

        Address64,
        
        NearBranch,
        
        FarBranch,
        
        FBSelector,

        MemSize, MemSeg, SegPrefix, MemBase, MemIndex, MemIndexScale, MemDx, MemDxSize,

        DecoderOptions,

    }

    public enum DecoderTestFieldWidth
    {
		Sequence = 12,

        Line = 8,

        Mnemonic = 12,

        Code = 48,

		Bitness = 8,

		CanEncode = 12,

		InvalidEOB = 10,

        DataWidth = 26,

		HexExpect = DataWidth, HexActual = DataWidth,

        OpMask = 12,

		Operands = 12, 

        OpReg = 14,

        OpKind = 14,

        Op0Kind = OpKind, Op1Kind = OpKind, Op2Kind = OpKind, Op3Kind = OpKind, Op4Kind = OpKind,

        Op0Reg = OpReg, Op1Reg = OpReg, Op2Reg= OpReg, Op3Reg= OpReg, Op4Reg = OpReg,

        Address64 = MemWidths,
        
        NearBranch = 12,
        
        FarBranch = MemWidths,
        
        FBSelector = 12,

        DecoderOptions = 8,

        MemWidths = 16,

        MemSize = MemWidths, MemSeg = MemWidths, SegPrefix = MemWidths, MemBase = MemWidths, 
        
        MemIndex = MemWidths, MemIndexScale = MemWidths, MemDx = MemWidths, MemDxSize = MemWidths,

        Offset = 16,
    }

    public enum DecoderTestField
    {
		Sequence = I.Sequence | W.Sequence << W.Offset,
        
        Line = I.Line | W.Line << W.Offset,

        Mnemonic = I.Mnemonic | W.Mnemonic << W.Offset,

        Code = I.Code | W.Code << W.Offset,

		Bits = I.Bitness | W.Bitness << W.Offset,

		CanEncode = I.CanEncode | W.CanEncode << W.Offset,

		InvalidEOB = I.InvalidEOB | W.InvalidEOB << W.Offset,

		HexInput = I.HexExpect | W.HexExpect << W.Offset,

		HexEncoded = I.HexActual | W.HexActual << W.Offset,

		OpMask = I.OpMask | W.OpMask << W.Offset,

		Operands = I.OpCount | W.Operands << W.Offset,

        Op0Kind = I.Op0Kind | W.Op0Kind << W.Offset,

        Op0Reg = I.Op0Reg | W.Op0Reg << W.Offset,

        Op1Kind = I.Op1Kind | W.Op1Kind << W.Offset,
        
        Op1Reg = I.Op1Reg | W.Op1Reg << W.Offset,

        Op2Kind = I.Op2Kind | W.Op2Kind << W.Offset,

        Op2Reg = I.Op2Reg | W.Op2Reg << W.Offset,

        Op3Kind = I.Op3Kind | W.Op3Kind << W.Offset,
        
        Op3Reg = I.Op3Reg | W.Op3Reg << W.Offset,

        Op4Kind = I.Op4Kind | W.Op4Kind << W.Offset,

        Op4Reg = I.Op4Reg | W.Op4Reg << W.Offset,
                     
        Address64 = I.Address64 | W.Address64 << W.Offset,
        
        NearBranch = I.NearBranch | W.NearBranch<< W.Offset,
        
        FarBranch = I.FarBranch | W.FarBranch << W.Offset,
        
        FBSelector = I.FBSelector | W.FBSelector << W.Offset,

        /*MemSize, MemSeg, SegPrefix, MemBase, MemIndex, MemIndexScale, MemDx, MemDxSize,*/
        MemSize = I.MemSize | W.MemSize << W.Offset,
        
        MemSeg = I.MemSeg | W.MemSeg << W.Offset,
        
        SegPrefix = I.SegPrefix | W.SegPrefix << W.Offset,
        
        MemBase  = I.MemBase | W.MemBase << W.Offset,
        
        MemIndex = I.MemIndex | W.MemIndex << W.Offset,
        
        MemIndexScale = I.MemIndexScale | W.MemIndexScale << W.Offset,
        
        MemDx = I.MemDx | W.MemDx << W.Offset,
        
        MemDxSize  = I.MemSize | W.MemSize << W.Offset,

        DecoderOptions = I.DecoderOptions | W.DecoderOptions << W.Offset,

    }
}