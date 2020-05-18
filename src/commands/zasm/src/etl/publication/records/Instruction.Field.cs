//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Tabular;

    using ID = InstructionFieldId;
    using W = InstructionFieldWidth;
    using static InstructionFieldCommon;

    class InstructionFieldCommon
    {
        public const int FlagWidth = 36;
    }

    public enum InstructionFieldId : int
    {
		Sequence, Id,  CodeInfo, Encoding, FlowControl, RflagsRead, RflagsUndefined,         
        RflagsWritten, RflagsCleared, RflagsSet, RflagsInfo, Cpuid,         
        Flags, OpInfo,
    }

    public enum InstructionFieldWidth : int
    {
		Sequence = 10, Id = 50, CodeInfo = 30, Encoding = 12, FlowControl = 22, 
        
        RflagsRead = FlagWidth, RflagsUndefined = FlagWidth,  RflagsWritten = FlagWidth, 
        
        RflagsCleared = FlagWidth, RflagsSet = FlagWidth, RflagsInfo = FlagWidth, 
        
        Cpuid = 20, Flags = 20, OpInfo = 10,

        Offset = 16,      
    }

    public enum InstructionField: int
    {
		Sequence = ID.Sequence | (W.Sequence << W.Offset),

		Id = ID.Id | (W.Id << W.Offset),
		
        CodeInfo = ID.CodeInfo | (W.CodeInfo << W.Offset),
		
        Encoding = ID.Encoding | (W.Encoding << W.Offset),
		
		FlowControl = ID.FlowControl | (W.FlowControl << W.Offset),
		
		RflagsRead = ID.RflagsRead | (W.RflagsRead << W.Offset),
		
		RflagsUndefined = ID.RflagsUndefined | (W.RflagsUndefined << W.Offset),
		
		RflagsWritten = ID.RflagsWritten | (W.RflagsWritten << W.Offset),
		
		RflagsCleared = ID.RflagsCleared | (W.RflagsCleared << W.Offset),
		
		RflagsSet = ID.RflagsSet | (W.RflagsSet << W.Offset),
		
		RflagsInfo = ID.RflagsInfo | (W.RflagsInfo << W.Offset),
		
		Cpuid = ID.Cpuid | (W.Cpuid << W.Offset),

		Flags = ID.Flags | (W.Flags << W.Offset),

		OpInfo = ID.OpInfo | (W.OpInfo << W.Offset),

    }

}

