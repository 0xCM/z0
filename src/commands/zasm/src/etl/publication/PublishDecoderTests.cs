//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;
    using static AsmDataModels;
    using static Asm.Data.OpKind;

    using F = DecoderTestField;
    using R = DecoderTestRecord;

    partial class AsmEtl
    {        
        IAsmArchiveConfig Config => this;

        public void PublishDecoderTests(OpCodeSpecs codes)
        {
            Publish(DecoderTests.Model,codes,16);
            Publish(DecoderTests.Model,codes,32);
            Publish(DecoderTests.Model,codes,64);
        }

        public AsmPublication<DecoderTestRecord> Publish(DecoderTests model, OpCodeSpecs codes, int bitness)
        {
            var src = Publish(model, codes, bitness,  out var dst);
            return AsmPublication.Flow(src, dst);            
        }

        IEnumerable<DecoderTestCase> DecoderCases(int bitness, FilePath src)
            => DecoderTestParser.ReadFile(bitness,src);

        IEnumerable<DecoderTestCase> ParseDecoderTests(int bitness)
        {
            foreach(var file in Config.IcedDecoderTests)
            {                
                if(file.Contains(bitness.ToString()))
                {
                    foreach(var test in DecoderCases(bitness,file))
                        yield return test;
                }
            }
        }

        DecoderTestRecord[] Publish(DecoderTests model, OpCodeSpecs codes, int bitness, out FilePath dst)
        {
            var src = ParseDecoderTests(bitness).OrderBy(x => x.Id).ToArray();
            var records = new DecoderTestRecord[src.Length];
            
            for(var i=0; i<src.Length; i++)
                records[i] = Record(model, codes, i, src[i]);

            dst = Config.DatasetPath(model.Name + bitness.ToString());
            Save(records, dst);
            term.print($"Saved {records.Length} decoder test case recoreds to {dst}");
            return records;
        }        

        R[] Save(DecoderTestRecord[] src, FilePath dst)
            => Records.Save<F,R>(src, dst, FormatRecord);

		string FormatRecord(DecoderTestRecord src)
		{
            var dst = Records.Formatter<F>();

            dst.DelimitField(F.Sequence, src.Sequence);
            dst.DelimitField(F.Mnemonic, src.Mnemonic);            
            dst.DelimitField(F.OpCode, src.OpCode);
            
            dst.DelimitField(F.Ops, src.Ops);

            dst.DelimitField(F.Op0K, R.Render(src.Op0K));
            dst.DelimitField(F.Op0R, R.Render(src.Op0R));

            dst.DelimitField(F.Op1K, R.Render(src.Op1K));
            dst.DelimitField(F.Op1R, R.Render(src.Op1R));
            
            dst.DelimitField(F.Op2K, R.Render(src.Op2K));
            dst.DelimitField(F.Op2R, R.Render(src.Op2R));
            
            dst.DelimitField(F.Op3K, R.Render(src.Op3K));
            dst.DelimitField(F.Op3R, R.Render(src.Op3R));
            
            dst.DelimitField(F.Op4K, R.Render(src.Op4K));
            dst.DelimitField(F.Op4R, R.Render(src.Op4R));

            dst.DelimitField(F.HexRef, R.RenderHex(src.HexRef));
            dst.DelimitField(F.HexEnc, R.RenderHex(src.HexEnc));

            dst.DelimitField(F.BitMode, src.BitMode);
            dst.DelimitField(F.CanEnc, R.Render(src.CanEnc));
            dst.DelimitField(F.InvEob, R.Render(src.InvEob));

            dst.DelimitField(F.OpMask, R.Render(src.OpMask));
            dst.DelimitField(F.Address64, R.RenderHex64(src.Address64));
            dst.DelimitField(F.NearBranch, R.RenderHex64(src.NearBranch));
            
            dst.DelimitField(F.FarBranch, R.RenderHex32(src.FarBranch));
            dst.DelimitField(F.FBSelector, R.RenderHex16(src.FBSelector));

            dst.DelimitField(F.MemSize, R.Render(src.MemSize));
            dst.DelimitField(F.MemSeg, R.Render(src.MemSeg));
            dst.DelimitField(F.SegPrefix, R.Render(src.SegPrefix));
            dst.DelimitField(F.MemBase, R.Render(src.MemBase));
            dst.DelimitField(F.MemIndex, R.Render(src.MemIndex));
            dst.DelimitField(F.MemIndexScale, R.RenderScale(src.MemIndexScale));
            dst.DelimitField(F.MemDx, R.RenderHex32(src.MemDx));
            dst.DelimitField(F.MemDxSize, R.RenderMemDxSize(src.MemDxSize));

            dst.DelimitField(F.Line, src.Line);
            dst.DelimitField(F.Id, src.Id);
            dst.DelimitField(F.DecoderOptions, src.DecoderOptions);
			return dst.ToString();
		}
        
		DecoderTestRecord Record(DecoderTests model, OpCodeSpecs codes,  int seq, DecoderTestCase src)
			=> new DecoderTestRecord(
				Sequence: seq,
                Line : src.LineNumber,
				Mnemonic : src.Mnemonic,
				Id: (OpCodeId)src.Code,
				BitMode: src.BitMode,
				CanEnc: src.CanEncode,
				InvEob: src.InvalidNoMoreBytes,
                OpCode: codes[(OpCodeId)src.Code].Expression,
				HexRef: src.HexBytes,
				HexEnc: src.EncodedHexBytes,
                OpMask: src.OpMask,
				Ops: src.OpCount,
                Op0K: src.Op0Kind,
                Op0R: src.Op0Register,
                Op1K: src.Op1Kind,
                Op1R: src.Op1Register,
                Op2K: src.Op2Kind,
                Op2R: src.Op2Register,
                Op3K: src.Op3Kind,
                Op3R: src.Op3Register,
                Op4K: src.Op4Kind,
                Op4R: src.Op4Register,
                Address64: src.MemoryAddress64,
                NearBranch: src.NearBranch,
                FarBranch:src.FarBranch,
                FBSelector: src.FarBranchSelector,
                
                MemSize: src.MemorySize,
                MemSeg: src.MemorySegment,
                SegPrefix: src.SegmentPrefix,
                MemBase: src.MemoryBase,
                MemIndex: src.MemoryIndex,
                MemIndexScale: src.MemoryIndexScale,
                MemDx: src.MemoryDisplacement,
                MemDxSize: src.MemoryDisplSize,
				
                DecoderOptions: src.DecoderOptions
			);
    }
}