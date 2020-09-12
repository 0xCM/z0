//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
	/// <summary>
	/// Contains information about an instruction, eg. read/written registers, read/written RFLAGS bits, CPUID feature bit, etc
	/// </summary>
	public struct InstructionInfo
    {
		/// true if the instruction isn't available in real mode or virtual 8086 mode
		/// </summary>
		public bool IsProtectedMode  {get;set;}

		/// <summary>
		/// true if this is a privileged instruction
		/// </summary>
		public bool IsPrivileged {get;set;}

		/// <summary>
		/// true if this is an instruction that implicitly uses the stack pointer (SP/ESP/RSP), eg. call, push, pop, ret, etc.
		/// See also <see cref="Instruction.StackPointerIncrement"/>
		/// </summary>
		public bool IsStackInstruction {get;set;}

		/// <summary>
		/// true if it's an instruction that saves or restores too many registers (eg. fxrstor, xsave, etc).
		/// <see cref="GetUsedRegisters"/> won't return all read/written registers.
		/// </summary>
		public bool IsSaveRestoreInstruction {get;set;}

		/// <summary>
		/// Instruction encoding, eg. legacy, VEX, EVEX, ...
		/// </summary>
		public EncodingKind Encoding {get;set;}

        //
        // Summary:
        //     All flags that are always cleared by the CPU
        public RflagsBits RflagsCleared { get; set;}
        //
        // Summary:
        //     All flags that are written by the CPU, except those flags that are known to be
        //     undefined, always set or always cleared. See also Iced.Intel.InstructionInfo.RflagsModified
        public RflagsBits RflagsWritten { get; set;}
        //
        // Summary:
        //     All flags that are read by the CPU when executing the instruction
        public RflagsBits RflagsRead { get; set;}

        //
        // Summary:
        //     All flags that are modified by the CPU. This is Iced.Intel.InstructionInfo.RflagsWritten
        //     + Iced.Intel.InstructionInfo.RflagsCleared + Iced.Intel.InstructionInfo.RflagsSet
        //     + Iced.Intel.InstructionInfo.RflagsUndefined
        public RflagsBits RflagsModified { get; set; }
        //
        // Summary:
        //     All flags that are always set by the CPU
        public RflagsBits RflagsSet { get; set;}

        //
        // Summary:
        //     All flags that are undefined after executing the instruction
        public RflagsBits RflagsUndefined { get; set;}

		/// <summary>
		/// Gets the CPU or CPUID feature flags
		/// </summary>
		public CpuidFeature[] CpuidFeatures  {get;set;}

		/// <summary>
		/// Flow control info
		/// </summary>
		public  FlowControl FlowControl {get;set;}

        public UsedMemory[] UsedMemory {get;set;}

        public UsedRegister[] UsedRegisters {get;set;}

        public OpAccess[] Access {get;set;}
	}
}

