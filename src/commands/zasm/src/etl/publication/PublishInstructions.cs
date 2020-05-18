//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Linq;

    using System.Collections.Generic;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;
    using static AsmDataModels;

    using F = InstructionField;
    using R = InstructionRecord;

    partial class AsmEtl
    {                        
        public AsmPublication<InstructionRecord> Publish(Instructions model)
        {
            var src = Publish(model, out var dst);
            return AsmPublication.Flow(src, dst);            
        }

        InstructionRecord[] Publish(Instructions model, out FilePath dst)
        {
            var src = InstrInfoTable.Data;
            var records = new InstructionRecord[src.Length];
            
            for(var i=0; i<src.Length; i++)
                records[i] = Record(model, i, src[i]);

            dst = Config.DatasetPath(model.Name);
            return Save(records, dst);
        }        

        R[] Save(InstructionRecord[] src, FilePath dst)
            => Records.Save<F,R>(src, dst, Format);

		string Format(OpInfo[] src) 
            => string.Join(", ", src.Where(x => x != 0).Map(x => x.ToString()));

		string Format(CpuidFeature[] src) 
            => string.Join(", ", src.Where(x => x != 0).Map(x => x.ToString()));

        string Format(RflagsBits src)
            => src == 0 ? string.Empty : src.ToString();

        string Format(InstrInfoFlags src)
            => src == 0 ? string.Empty : src.ToString();

        string Format(CodeInfo src)
            => src == 0 ? string.Empty : src.ToString();

		string Format(InstructionRecord src)
		{
            var dst = Records.Formatter<F>();
            dst.DelimitField(F.Sequence, src.Sequence);
            dst.DelimitField(F.Id, src.Id);
            dst.DelimitField(F.CodeInfo, Format(src.CodeInfo));
            dst.DelimitField(F.Encoding, src.Encoding);
            dst.DelimitField(F.FlowControl, src.FlowControl);
            dst.DelimitField(F.RflagsRead, Format(src.RflagsRead));
            dst.DelimitField(F.RflagsUndefined, Format(src.RflagsUndefined));
            dst.DelimitField(F.RflagsWritten, Format(src.RflagsWritten));
            dst.DelimitField(F.RflagsCleared, Format(src.RflagsCleared));
            dst.DelimitField(F.RflagsSet, Format(src.RflagsSet));
            dst.DelimitField(F.RflagsInfo, Format(src.RflagsInfo));
            dst.DelimitField(F.Cpuid, Format(src.Cpuid));
            dst.DelimitField(F.Flags, Format(src.Flags));
            dst.DelimitField(F.OpInfo, Format(src.OpInfo));
			return dst.ToString();
		}

		InstructionRecord Record(Instructions model, int seq, InstrInfo src)
			=> new InstructionRecord(
				Sequence: seq,
                Id : (Code)src.Code.Value,
				CodeInfo : src.CodeInfo,
				Encoding: (EncodingKind)src.Encoding.Value,
				FlowControl: (FlowControl)src.FlowControl.Value,
				RFlagsRead: src.RflagsRead,
				RflagsUndefined: src.RflagsUndefined,
				RflagsWritten: src.RflagsWritten,
				RflagsCleared: src.RflagsCleared,
				RflagsSet: src.RflagsSet,
				RflagsInfo: (RflagsBits)(src.RflagsInfo?.Value ?? 0),
				Cpuid: Control.map(src.Cpuid, x => (CpuidFeature)x.Value),
				Flags: src.Flags,
				OpInfo: src.OpInfo
			);
    }
}