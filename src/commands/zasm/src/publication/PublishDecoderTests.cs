//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    using M = AsmDataModels;
    using F = DecoderTestField;
    using R = DecoderTestRecord;
    using RF = AsmRecordFormatter;

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

        Publication<DecoderTestRecord> Publish(IDataModel model, OpCodeRecords codes, int bitness)
        {
            var src = Publish(model, codes, bitness,  out var dst);
            return Publications.Flow(src, dst);            
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

        DecoderTestRecord[] Publish(IDataModel model, OpCodeRecords codes, int bitness, out FilePath dst)
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

            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);            
            dst.Delimit(F.OpCode, src.OpCode);
            
            dst.Delimit(F.Ops, src.Ops);

            dst.Delimit(F.Op0K, RF.Render(src.Op0K));
            dst.Delimit(F.Op0R, RF.Render(src.Op0R));

            dst.Delimit(F.Op1K, RF.Render(src.Op1K));
            dst.Delimit(F.Op1R, RF.Render(src.Op1R));
            
            dst.Delimit(F.Op2K, RF.Render(src.Op2K));
            dst.Delimit(F.Op2R, RF.Render(src.Op2R));
            
            dst.Delimit(F.Op3K, RF.Render(src.Op3K));
            dst.Delimit(F.Op3R, RF.Render(src.Op3R));
            
            dst.Delimit(F.Op4K, RF.Render(src.Op4K));
            dst.Delimit(F.Op4R, RF.Render(src.Op4R));

            dst.Delimit(F.HexRef, RF.RenderHex(src.HexRef));
            dst.Delimit(F.HexEnc, RF.RenderHex(src.HexEnc));

            dst.Delimit(F.BitMode, src.BitMode);
            dst.Delimit(F.CanEnc, RF.Render(src.CanEnc));
            dst.Delimit(F.InvEob, RF.Render(src.InvEob));

            dst.Delimit(F.OpMask, RF.Render(src.OpMask));
            dst.Delimit(F.Address64, RF.RenderHex64(src.Address64));
            dst.Delimit(F.NearBranch, RF.RenderHex64(src.NearBranch));
            
            dst.Delimit(F.FarBranch, RF.RenderHex32(src.FarBranch));
            dst.Delimit(F.FBSelector, RF.RenderHex16(src.FBSelector));

            dst.Delimit(F.MemSize, RF.Render(src.MemSize));
            dst.Delimit(F.MemSeg, RF.Render(src.MemSeg));
            dst.Delimit(F.SegPrefix, RF.Render(src.SegPrefix));
            dst.Delimit(F.MemBase, RF.Render(src.MemBase));
            dst.Delimit(F.MemIndex, RF.Render(src.MemIndex));
            dst.Delimit(F.MemIndexScale, RF.RenderScale(src.MemIndexScale));
            dst.Delimit(F.MemDx, RF.RenderHex32(src.MemDx));
            dst.Delimit(F.MemDxSize, RF.RenderMemDxSize(src.MemDxSize));

            dst.Delimit(F.Line, src.Line);
            dst.Delimit(F.Id, src.Id);
            dst.Delimit(F.DecoderOptions, src.DecoderOptions);
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