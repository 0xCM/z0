//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using I = InstructionFieldId;
    using W = InstructionFieldWidth;
    using R = RecordFields;

    public enum InstructionFieldId : int
    {
		Sequence, Id,  CodeInfo, Encoding, FlowControl, RflagsRead, RflagsUndefined,         

        RflagsWritten, RflagsCleared, RflagsSet, RflagsInfo, Cpuid,         

        Flags, OpInfo,
    }

    public enum InstructionFieldWidth : int
    {
        FlagWidth = 36, 

		Sequence = R.SeqWidth, Id = R.IdWidth, CodeInfo = 30, Encoding = 12, FlowControl = 22, 
        
        RflagsRead = FlagWidth, RflagsUndefined = FlagWidth,  RflagsWritten = FlagWidth, 
        
        RflagsCleared = FlagWidth, RflagsSet = FlagWidth, RflagsInfo = FlagWidth, 
        
        Cpuid = 20, Flags = 20, OpInfo = 10,

    }

    public enum InstructionField: int
    {
		Sequence = I.Sequence | (W.Sequence << R.Offset),

		Id = I.Id | (W.Id << R.Offset),
		
        CodeInfo = I.CodeInfo | (W.CodeInfo << R.Offset),
		
        Encoding = I.Encoding | (W.Encoding << R.Offset),
		
		FlowControl = I.FlowControl | (W.FlowControl << R.Offset),
		
		RflagsRead = I.RflagsRead | (W.RflagsRead << R.Offset),
		
		RflagsUndefined = I.RflagsUndefined | (W.RflagsUndefined << R.Offset),
		
		RflagsWritten = I.RflagsWritten | (W.RflagsWritten << R.Offset),
		
		RflagsCleared = I.RflagsCleared | (W.RflagsCleared << R.Offset),
		
		RflagsSet = I.RflagsSet | (W.RflagsSet << R.Offset),
		
		RflagsInfo = I.RflagsInfo | (W.RflagsInfo << R.Offset),
		
		Cpuid = I.Cpuid | (W.Cpuid << R.Offset),

		Flags = I.Flags | (W.Flags << R.Offset),

		OpInfo = I.OpInfo | (W.OpInfo << R.Offset),

    }

}

