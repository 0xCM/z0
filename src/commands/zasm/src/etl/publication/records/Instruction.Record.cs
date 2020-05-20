//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using Z0.Asm.Data;

    using R = InstructionRecord;
    using F = InstructionField;

    public readonly struct InstructionRecord : IRecord<F,R>
    {
		public int Sequence {get;}

		public readonly Code Id;
		
        public readonly CodeInfo CodeInfo;
		
        public readonly EncodingKind Encoding;
		
		public readonly FlowControl FlowControl;
		
		public readonly RflagsBits RflagsRead;
		
		public readonly RflagsBits RflagsUndefined;
		
		public readonly RflagsBits RflagsWritten;
		
		public readonly RflagsBits RflagsCleared;
		
		public readonly RflagsBits RflagsSet;
		
		public readonly RflagsBits RflagsInfo;
		
		public readonly CpuidFeature[] Cpuid;

		public readonly InstrInfoFlags Flags;

		public readonly OpInfo[] OpInfo;
		
		public InstructionRecord(
			int Sequence,
			Code Id, 
			CodeInfo CodeInfo,
			EncodingKind Encoding, 
			FlowControl FlowControl, 
			RflagsBits RFlagsRead, 
			RflagsBits RflagsUndefined,
			RflagsBits RflagsWritten,
			RflagsBits RflagsCleared,
			RflagsBits RflagsSet,
			RflagsBits RflagsInfo,
			CpuidFeature[] Cpuid,
			InstrInfoFlags Flags,
			OpInfo[] OpInfo
			)
		{
			this.Sequence = Sequence;
			this.Id = Id;
			this.CodeInfo = CodeInfo;
			this.Encoding = Encoding; 
			this.FlowControl = FlowControl; 
			this.RflagsRead = RFlagsRead; 
			this.RflagsUndefined = RflagsUndefined; 
			this.RflagsWritten = RflagsWritten; 
			this.RflagsCleared = RflagsCleared; 
			this.RflagsSet = RflagsSet; 
			this.RflagsInfo = RflagsInfo; 
			this.Cpuid = Cpuid;
			this.Flags = Flags;
			this.OpInfo = OpInfo;
		}
    }
}