//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using I = InstructionFieldId;
    using W = InstructionFieldWidth;
    using RW = AsmFieldWidths;

    public enum InstructionFieldId
    {
		Sequence, Id,  CodeInfo, Encoding, FlowControl, RflagsRead, RflagsUndefined,         

        RflagsWritten, RflagsCleared, RflagsSet, RflagsInfo, Cpuid,         

        Flags, OpInfo,
    }

    public enum InstructionFieldWidth
    {
        FlagWidth = 36, 

		CodeInfo = 30, Encoding = 12, FlowControl = 22, 
        
        RflagsRead = FlagWidth, RflagsUndefined = FlagWidth,  RflagsWritten = FlagWidth, 
        
        RflagsCleared = FlagWidth, RflagsSet = FlagWidth, RflagsInfo = FlagWidth, 
        
        Cpuid = 20, Flags = 20, OpInfo = 10,

    }

    public enum InstructionField
    {
		Sequence = I.Sequence | (RW.Sequence << RW.Offset),

		Id = I.Id | (RW.Id << RW.Offset),
		
        CodeInfo = I.CodeInfo | (W.CodeInfo << RW.Offset),
		
        Encoding = I.Encoding | (W.Encoding << RW.Offset),
		
		FlowControl = I.FlowControl | (W.FlowControl << RW.Offset),
		
		RflagsRead = I.RflagsRead | (W.RflagsRead << RW.Offset),
		
		RflagsUndefined = I.RflagsUndefined | (W.RflagsUndefined << RW.Offset),
		
		RflagsWritten = I.RflagsWritten | (W.RflagsWritten << RW.Offset),
		
		RflagsCleared = I.RflagsCleared | (W.RflagsCleared << RW.Offset),
		
		RflagsSet = I.RflagsSet | (W.RflagsSet << RW.Offset),
		
		RflagsInfo = I.RflagsInfo | (W.RflagsInfo << RW.Offset),
		
		Cpuid = I.Cpuid | (W.Cpuid << RW.Offset),

		Flags = I.Flags | (W.Flags << RW.Offset),

		OpInfo = I.OpInfo | (W.OpInfo << RW.Offset),
    }
}

