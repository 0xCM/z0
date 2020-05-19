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
            => Records.Save<F,R>(src, dst, FormatRecord, FormatHeader);

        string FormatHeader(int index, F field)
        {
            var label = field.ToString();
            switch(field)
            {
                case F.Op0Kind:
                    label = $"Op[0]:kind";
                    break;
                case F.Op0Reg:
                    label = $"Op[0]:reg";
                    break;

                case F.Op1Kind:
                    label = $"Op[1]:kind";
                    break;
                case F.Op1Reg:
                    label = $"Op[1]:reg";
                    break;

                case F.Op2Kind:
                    label = $"Op[2]:kind";
                    break;
                case F.Op2Reg:
                    label = $"Op[2]:reg";
                    break;

                case F.Op3Kind:
                    label = $"Op[3]:kind";
                    break;
                case F.Op3Reg:
                    label = $"Op[3]:reg";
                    break;

                case F.Op4Kind:
                    label = $"Op[4]:kind";
                    break;
                case F.Op4Reg:
                    label = $"Op[4]:reg";
                    break;
            }
            return label;
        }
        public string Render(OpKind src)
        {
            var si = SegIndicator.From(src);
            if(si.IsNonEmpty)
                return si.Format();

            var result = src switch{
                OpKind.Register => "reg",
                NearBranch16 => "branch16",
                NearBranch32 => "branch32",
                NearBranch64 => "branch64",
                FarBranch16 => "farbranch16",
                FarBranch32 => "farbranch32",
                Immediate8 => "imm8",
                Immediate8_2nd => "imm8x2",
                Immediate16 => "imm16",
                Immediate32 => "imm32",
                Immediate64 => "imm64",
                Immediate8to16 => "imm16i",
                Immediate8to32 => "imm32i",
                Immediate8to64 => "imm64i",
                Immediate32to64 => "imm32x64i",
                Memory64 => "mem64",
                Memory => "mem",
                    _ => src.ToString()
            };

            return result;
        }

        string Render(Register src)
            => src != 0 ? src.ToString() : string.Empty;

        string NormalizeHex(string src)
            => src.RemoveBlanks().BlockPartition(2,Chars.Space);

        string RenderHex16(ushort src)
            => src == 0 ? string.Empty : src.FormatHex(true,false);

        string RenderHex32(uint src)
            => src == 0 ? string.Empty : src.FormatHex(false,true, prespec:false);

        string RenderHex32(int src)
            => src == 0 ? string.Empty : src.FormatHex(false,false);

        string RenderHex64(ulong src)
            => src == 0 ? string.Empty : src.FormatHex(false,false);

        string Render(MemorySize src)
            => src != 0 ? src.ToString() : string.Empty;

		string FormatRecord(DecoderTestRecord src)
		{
            var dst = Records.Formatter<F>();

            dst.DelimitField(F.Sequence, src.Sequence);
            dst.DelimitField(F.Line, src.Line);
            dst.DelimitField(F.Mnemonic, src.Mnemonic);
            
            dst.DelimitField(F.OpCode, src.OpCode);
            dst.DelimitField(F.HexInput, NormalizeHex(src.Input));
            dst.DelimitField(F.HexEncoded, NormalizeHex(src.Encoded));

            dst.DelimitField(F.Bits, src.Bits);
            dst.DelimitField(F.CanEncode, src.CanEncode);
            dst.DelimitField(F.InvalidEOB, src.InvalidEOB);

            dst.DelimitField(F.OpMask, Render(src.OpMask));
            dst.DelimitField(F.Operands, src.OpCount);

            dst.DelimitField(F.Op0Kind, Render(src.Op0Kind));
            dst.DelimitField(F.Op0Reg, Render(src.Op0Reg));

            dst.DelimitField(F.Op1Kind, Render(src.Op1Kind));
            dst.DelimitField(F.Op1Reg, Render(src.Op1Reg));
            
            dst.DelimitField(F.Op2Kind, Render(src.Op2Kind));
            dst.DelimitField(F.Op2Reg, Render(src.Op2Reg));
            
            dst.DelimitField(F.Op3Kind, Render(src.Op3Kind));
            dst.DelimitField(F.Op3Reg, Render(src.Op3Reg));
            
            dst.DelimitField(F.Op4Kind, Render(src.Op4Kind));
            dst.DelimitField(F.Op4Reg, Render(src.Op4Reg));

            dst.DelimitField(F.Address64, RenderHex64(src.Address64));
            dst.DelimitField(F.NearBranch, RenderHex64(src.NearBranch));
            
            dst.DelimitField(F.FarBranch, RenderHex32(src.FarBranch));
            dst.DelimitField(F.FBSelector, RenderHex16(src.FBSelector));

            dst.DelimitField(F.MemSize, Render(src.MemSize));
            dst.DelimitField(F.MemSeg, Render(src.MemSeg));
            dst.DelimitField(F.SegPrefix, Render(src.SegPrefix));
            dst.DelimitField(F.MemBase, Render(src.MemBase));
            dst.DelimitField(F.MemIndex, Render(src.MemIndex));
            dst.DelimitField(F.MemIndexScale, src.MemIndexScale != 0 ? src.MemIndexScale.ToString() : string.Empty);
            dst.DelimitField(F.MemDx, RenderHex32(src.MemDx));
            dst.DelimitField(F.MemDxSize, src.MemDxSize != 0 ? src.MemDxSize.ToString() : string.Empty);

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
				Bits: src.Bitness,
				CanEncode: src.CanEncode,
				InvalidEOB: src.InvalidNoMoreBytes,
                OpCode: codes[(OpCodeId)src.Code].Expression,
				HexBytes: src.HexBytes,
				EncodedHexBytes: src.EncodedHexBytes,
                OpMask: src.OpMask,
				OpCount: src.OpCount,
                Op0Kind: src.Op0Kind,
                Op0Reg: src.Op0Register,
                Op1Kind: src.Op1Kind,
                Op1Reg: src.Op1Register,
                Op2Kind: src.Op2Kind,
                Op2Reg: src.Op2Register,
                Op3Kind: src.Op3Kind,
                Op3Reg: src.Op3Register,
                Op4Kind: src.Op4Kind,
                Op4Reg: src.Op4Register,
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