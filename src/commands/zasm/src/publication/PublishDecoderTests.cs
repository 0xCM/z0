//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;
    
    using M = AsmDataModels;
    using F = DecoderTestField;
    using R = DecoderTestRecord;
    using RF = RecordFormatter;

    partial class AsmEtl
    {        
        IAsmArchiveConfig Config => this;

        public IEnumerable<Publication<DecoderTestRecord>> Publish(M.DecoderTests model, OpCodeRecords codes)
        {
            yield return Publish(M.DecoderTests.Model16, codes);
            yield return Publish(M.DecoderTests.Model32, codes);
            yield return Publish(M.DecoderTests.Model64, codes);
        }

        Publication<DecoderTestRecord> Publish(M.DecoderTests16 model, OpCodeRecords codes)
            => Publish(model, codes, 16);

        Publication<DecoderTestRecord> Publish(M.DecoderTests32 model, OpCodeRecords codes)
            => Publish(model, codes, 32);

        Publication<DecoderTestRecord> Publish(M.DecoderTests64 model, OpCodeRecords codes)
            => Publish(model, codes, 64);

        Publication<DecoderTestRecord> Publish(IAsmDataModel model, OpCodeRecords codes, int bitness)
        {
            var src = Publish(model, codes, bitness,  out var dst);
            return Publication.Flow(src, dst);            
        }

        IEnumerable<DecoderTestCase> DecoderCases(int bitness, FilePath src)
            => DecoderTestParser.ReadFile(bitness,src);

        IEnumerable<DecoderTestCase> ParseDecoderTests(int bitness)
        {
            foreach(var file in Config.DecoderTests)
            {                
                if(file.Contains(bitness.ToString()))
                {
                    foreach(var test in DecoderCases(bitness,file))
                        yield return test;
                }
            }
        }

        DecoderTestRecord[] Publish(IAsmDataModel model, OpCodeRecords codes, int bitness, out FilePath dst)
        {
            var src = ParseDecoderTests(bitness).OrderBy(x => x.Id).ToArray();
            var records = new DecoderTestRecord[src.Length];
            
            for(var i=0; i<src.Length; i++)
                records[i] = Record(codes, i, src[i]);

            dst = Config.DatasetPath(model);
            Save(records, dst);
            term.print($"Saved {records.Length} decoder test case recoreds to {dst}");
            return records;
        }        

        R[] Save(DecoderTestRecord[] src, FilePath dst)
            => AsmRecords.Save<F,R>(src, dst, FormatRecord);

		string FormatRecord(DecoderTestRecord src)
		{
            var dst = AsmRecords.Formatter<F>();

            dst.DelimitField(F.Sequence, src.Sequence);
            dst.DelimitField(F.Mnemonic, src.Mnemonic);            
            dst.DelimitField(F.OpCode, src.OpCode);
            
            dst.DelimitField(F.Ops, src.Ops);

            dst.DelimitField(F.Op0K, RF.Render(src.Op0K));
            dst.DelimitField(F.Op0R, RF.Render(src.Op0R));

            dst.DelimitField(F.Op1K, RF.Render(src.Op1K));
            dst.DelimitField(F.Op1R, RF.Render(src.Op1R));
            
            dst.DelimitField(F.Op2K, RF.Render(src.Op2K));
            dst.DelimitField(F.Op2R, RF.Render(src.Op2R));
            
            dst.DelimitField(F.Op3K, RF.Render(src.Op3K));
            dst.DelimitField(F.Op3R, RF.Render(src.Op3R));
            
            dst.DelimitField(F.Op4K, RF.Render(src.Op4K));
            dst.DelimitField(F.Op4R, RF.Render(src.Op4R));

            dst.DelimitField(F.HexRef, RF.RenderHex(src.HexRef));
            dst.DelimitField(F.HexEnc, RF.RenderHex(src.HexEnc));

            dst.DelimitField(F.BitMode, src.BitMode);
            dst.DelimitField(F.CanEnc, RF.Render(src.CanEnc));
            dst.DelimitField(F.InvEob, RF.Render(src.InvEob));

            dst.DelimitField(F.OpMask, RF.Render(src.OpMask));
            dst.DelimitField(F.Address64, RF.RenderHex64(src.Address64));
            dst.DelimitField(F.NearBranch, RF.RenderHex64(src.NearBranch));
            
            dst.DelimitField(F.FarBranch, RF.RenderHex32(src.FarBranch));
            dst.DelimitField(F.FBSelector, RF.RenderHex16(src.FBSelector));

            dst.DelimitField(F.MemSize, RF.Render(src.MemSize));
            dst.DelimitField(F.MemSeg, RF.Render(src.MemSeg));
            dst.DelimitField(F.SegPrefix, RF.Render(src.SegPrefix));
            dst.DelimitField(F.MemBase, RF.Render(src.MemBase));
            dst.DelimitField(F.MemIndex, RF.Render(src.MemIndex));
            dst.DelimitField(F.MemIndexScale, RF.RenderScale(src.MemIndexScale));
            dst.DelimitField(F.MemDx, RF.RenderHex32(src.MemDx));
            dst.DelimitField(F.MemDxSize, RF.RenderMemDxSize(src.MemDxSize));

            dst.DelimitField(F.Line, src.Line);
            dst.DelimitField(F.Id, src.Id);
            dst.DelimitField(F.DecoderOptions, src.DecoderOptions);
			return dst.ToString();
		}
        
		DecoderTestRecord Record(OpCodeRecords codes,  int seq, DecoderTestCase src)
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