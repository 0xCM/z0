//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding 
{
    using System.Linq;
    using System;
    using System.Reflection;

	public sealed class InstrInfo 
    {
		public IceEnumValue Code { get; }
		public CodeInfo CodeInfo { get; }
		public IceEnumValue Encoding { get; }
		public IceEnumValue FlowControl { get; }
		public RflagsBits RflagsRead { get; }
		public RflagsBits RflagsUndefined { get; }
		public RflagsBits RflagsWritten { get; }
		public RflagsBits RflagsCleared { get; }
		public RflagsBits RflagsSet { get; }
		public IceEnumValue? RflagsInfo { get; internal set; }
		public IceEnumValue[] Cpuid { get; }
		public IceEnumValue? CpuidInternal { get; internal set; }
		public InstrInfoFlags Flags { get; }
		public OpInfo[] OpInfo { get; }
		public IceEnumValue[] OpInfoEnum { get; }
		public InstrInfo(IceEnumValue code, CodeInfo codeInfo, IceEnumValue encoding, IceEnumValue flowControl, RflagsBits read, RflagsBits undefined, RflagsBits written, RflagsBits cleared, RflagsBits set, IceEnumValue[] cpuid, OpInfo[] opInfo, InstrInfoFlags flags) {
			Code = code;
			CodeInfo = codeInfo;
			Encoding = encoding;
			FlowControl = flowControl;
			RflagsRead = read;
			RflagsUndefined = undefined;
			RflagsWritten = written;
			RflagsCleared = cleared;
			RflagsSet = set;
			RflagsInfo = null;
			Cpuid = cpuid;
			CpuidInternal = null;
			OpInfo = opInfo;
			OpInfoEnum = new IceEnumValue[opInfo.Length];
			Flags = flags;
		}
	}
}