//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Text;
	using System.Runtime.CompilerServices;

	// GENERATOR-END: CodeInfo

	public static class InstructionData
	{
		/// <summary>
		/// Negates the condition code, eg. <c>JE</c> -> <c>JNE</c>. Can be used if it's <c>Jcc</c>, <c>SETcc</c>, <c>CMOVcc</c> and returns
		/// the original value if it's none of those instructions.
		/// </summary>
		public static OpCodeId NegateConditionCode(OpCodeId id)
			=> (OpCodeId)(((Code)id).NegateConditionCode());


		/// <summary>
		/// Converts <c>Jcc/JMP NEAR</c> to <c>Jcc/JMP SHORT</c>. Returns the input if it's not a <c>Jcc/JMP NEAR</c> instruction.
		/// </summary>
		/// <param name="code">Code value</param>
		public static OpCodeId ToShortBranch(OpCodeId id)
			=> (OpCodeId)((Code)id).ToShortBranch();


		/// <summary>
		/// Converts <c>Jcc/JMP SHORT</c> to <c>Jcc/JMP NEAR</c>. Returns the input if it's not a <c>Jcc/JMP SHORT</c> instruction.
		/// </summary>
		/// <param name="code">Code value</param>
		public static OpCodeId ToNearBranch(OpCodeId id)
			=> (OpCodeId)((Code)id).ToNearBranch();

		public static bool IsProtectedMode(OpCodeId id)
			=> ((Code)id).IsProtectedMode();

		/// <summary>
		/// Checks if this is a privileged instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsPrivileged(OpCodeId id)
			=> ((Code)id).IsPrivileged();

		/// <summary>
		/// Gets the encoding, eg. legacy, VEX, EVEX, ...
		/// </summary>
		/// <param name="code">Code value</param>
		public static EncodingKind Encoding(OpCodeId id)
			=> ((Code)id).Encoding();

		public static CpuidFeature[] CpuidFeatures(OpCodeId id)
			=> ((Code)id).CpuidFeatures();

		public static FlowControl FlowControl(OpCodeId id)			
			=> ((Code)id).FlowControl();

		/// <summary>
		/// Checks if it's a <c>JMP FAR [mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsCallFarIndirect(OpCodeId id)
			=> ((Code)id).IsJmpFarIndirect();

		/// <summary>
		/// Checks if it's a <c>JMP FAR [mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJmpFarIndirect(OpCodeId id) 
			=> ((Code)id).IsJmpFarIndirect();

		/// <summary>
		/// Checks if it's a <c>CALL NEAR reg/[mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsCallNearIndirect(OpCodeId id) =>
			((Code)id).IsCallNearIndirect();

		/// <summary>
		/// Checks if it's a <c>Jcc SHORT</c> or <c>Jcc NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJccShortOrNear(OpCodeId id)			
			=> ((Code)id).IsJccShortOrNear();

		/// <summary>
		/// Gets the condition code if it's <c>Jcc</c>, <c>SETcc</c>, <c>CMOVcc</c> else <see cref="ConditionCode.None"/> is returned
		/// </summary>
		/// <param name="code">Code value</param>
		public static ConditionCode ConditionCode(OpCodeId id)
			=> ((Code)id).ConditionCode();

		/// <summary>
		/// Checks if it's a <c>Jcc NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJccNear(OpCodeId id)
			=> ((Code)id).IsJccShortOrNear();

		/// <summary>
		/// Checks if it's a <c>Jcc SHORT</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJccShort(OpCodeId id)
			=> ((Code)id).IsJccShortOrNear();

		/// <summary>
		/// Checks if it's a <c>JMP SHORT</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJmpShort(OpCodeId id)
			=> ((Code)id).IsJccShortOrNear();

		/// <summary>
		/// Checks if it's a <c>JMP FAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJmpFar(OpCodeId id)
			=> ((Code)id).IsJmpFar();

		/// <summary>
		/// Checks if it's a <c>CALL NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsCallNear(OpCodeId id)
			=> ((Code)id).IsCallNear();

		/// <summary>
		/// Checks if it's a <c>JMP NEAR reg/[mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		public static bool IsJmpNearIndirect(OpCodeId id) 
			=> ((Code)id).IsJmpNearIndirect();		
	}

	public static class InstructionInfoX
	{

		/// <summary>
		/// Negates the condition code, eg. <c>JE</c> -> <c>JNE</c>. Can be used if it's <c>Jcc</c>, <c>SETcc</c>, <c>CMOVcc</c> and returns
		/// the original value if it's none of those instructions.
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		public static Code NegateConditionCode(this Code code) {
			uint t;

			if ((t = (uint)(code - Code.Jo_rel16)) <= (uint)(Code.Jg_rel32_64 - Code.Jo_rel16) ||
				(t = (uint)(code - Code.Jo_rel8_16)) <= (uint)(Code.Jg_rel8_64 - Code.Jo_rel8_16) ||
				(t = (uint)(code - Code.Cmovo_r16_rm16)) <= (uint)(Code.Cmovg_r64_rm64 - Code.Cmovo_r16_rm16)) {
				// They're ordered, eg. je_16, je_32, je_64, jne_16, jne_32, jne_64
				// if low 3, add 3, else if high 3, subtract 3.
				//return (((int)((t / 3) << 31) >> 31) | 1) * 3 + code;
				if (((t / 3) & 1) != 0)
					return code - 3;
				return code + 3;
			}

			t = (uint)(code - Code.Seto_rm8);
			if (t <= (uint)(Code.Setg_rm8 - Code.Seto_rm8))
				return (int)(t ^ 1) + Code.Seto_rm8;

			return code;
		}

		/// <summary>
		/// Converts <c>Jcc/JMP NEAR</c> to <c>Jcc/JMP SHORT</c>. Returns the input if it's not a <c>Jcc/JMP NEAR</c> instruction.
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		public static Code ToShortBranch(this Code code) {
			uint t;

			t = (uint)(code - Code.Jo_rel16);
			if (t <= (uint)(Code.Jg_rel32_64 - Code.Jo_rel16))
				return (int)t + Code.Jo_rel8_16;

			t = (uint)(code - Code.Jmp_rel16);
			if (t <= (uint)(Code.Jmp_rel32_64 - Code.Jmp_rel16))
				return (int)t + Code.Jmp_rel8_16;

			return code;
		}

		/// <summary>
		/// Converts <c>Jcc/JMP SHORT</c> to <c>Jcc/JMP NEAR</c>. Returns the input if it's not a <c>Jcc/JMP SHORT</c> instruction.
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		public static Code ToNearBranch(this Code code) {
			uint t;

			t = (uint)(code - Code.Jo_rel8_16);
			if (t <= (uint)(Code.Jg_rel8_64 - Code.Jo_rel8_16))
				return (int)t + Code.Jo_rel16;

			t = (uint)(code - Code.Jmp_rel8_16);
			if (t <= (uint)(Code.Jmp_rel8_64 - Code.Jmp_rel8_16))
				return (int)t + Code.Jmp_rel16;

			return code;
		}

		/// <summary>
		/// Gets the encoding, eg. legacy, VEX, EVEX, ...
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static EncodingKind Encoding(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2 + 1;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (EncodingKind)((data[index] >> (int)InfoFlags2.EncodingShift) & (uint)InfoFlags2.EncodingMask);
		}

		/// <summary>
		/// Gets the CPU or CPUID feature flags
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CpuidFeature[] CpuidFeatures(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2 + 1;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			var cpuidFeature = (CpuidFeatureInternal)((data[index] >> (int)InfoFlags2.CpuidFeatureInternalShift) & (uint)InfoFlags2.CpuidFeatureInternalMask);
			return CpuidFeatureInternalData.ToCpuidFeatures[(int)cpuidFeature];
		}

		/// <summary>
		/// Gets flow control info
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static FlowControl FlowControl(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2 + 1;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (FlowControl)((data[index] >> (int)InfoFlags2.FlowControlShift) & (uint)InfoFlags2.FlowControlMask);
		}

		/// <summary>
		/// Checks if the instruction isn't available in real mode or virtual 8086 mode
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsProtectedMode(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (data[index] & (uint)InfoFlags1.ProtectedMode) != 0;
		}

		/// <summary>
		/// Checks if this is a privileged instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPrivileged(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (data[index] & (uint)InfoFlags1.Privileged) != 0;
		}

		/// <summary>
		/// Checks if this is an instruction that implicitly uses the stack pointer (<c>SP</c>/<c>ESP</c>/<c>RSP</c>), eg. <c>CALL</c>, <c>PUSH</c>, <c>POP</c>, <c>RET</c>, etc.
		/// See also <see cref="Instruction.StackPointerIncrement"/>
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsStackInstruction(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (data[index] & (uint)InfoFlags1.StackInstruction) != 0;
		}

		/// <summary>
		/// Checks if it's an instruction that saves or restores too many registers (eg. <c>FXRSTOR</c>, <c>XSAVE</c>, etc).
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsSaveRestoreInstruction(this Code code) {
			var data = InstInfoData.Data;
			int index = (int)code * 2;
			if ((uint)index >= (uint)data.Length)
				throw new ArgumentException();
			return (data[index] & (uint)InfoFlags1.SaveRestore) != 0;
		}

		/// <summary>
		/// Checks if it's a <c>Jcc SHORT</c> or <c>Jcc NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJccShortOrNear(this Code code) =>
			(uint)(code - Code.Jo_rel8_16) <= (uint)(Code.Jg_rel8_64 - Code.Jo_rel8_16) ||
			(uint)(code - Code.Jo_rel16) <= (uint)(Code.Jg_rel32_64 - Code.Jo_rel16);

		/// <summary>
		/// Checks if it's a <c>Jcc NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJccNear(this Code code) =>
			(uint)(code - Code.Jo_rel16) <= (uint)(Code.Jg_rel32_64 - Code.Jo_rel16);

		/// <summary>
		/// Checks if it's a <c>Jcc SHORT</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJccShort(this Code code) =>
			(uint)(code - Code.Jo_rel8_16) <= (uint)(Code.Jg_rel8_64 - Code.Jo_rel8_16);

		/// <summary>
		/// Checks if it's a <c>JMP SHORT</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpShort(this Code code) =>
			(uint)(code - Code.Jmp_rel8_16) <= (uint)(Code.Jmp_rel8_64 - Code.Jmp_rel8_16);

		/// <summary>
		/// Checks if it's a <c>JMP NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpNear(this Code code) =>
			(uint)(code - Code.Jmp_rel16) <= (uint)(Code.Jmp_rel32_64 - Code.Jmp_rel16);

		/// <summary>
		/// Checks if it's a <c>JMP SHORT</c> or a <c>JMP NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpShortOrNear(this Code code) =>
			(uint)(code - Code.Jmp_rel8_16) <= (uint)(Code.Jmp_rel8_64 - Code.Jmp_rel8_16) ||
			(uint)(code - Code.Jmp_rel16) <= (uint)(Code.Jmp_rel32_64 - Code.Jmp_rel16);

		/// <summary>
		/// Checks if it's a <c>JMP FAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpFar(this Code code) =>
			(uint)(code - Code.Jmp_ptr1616) <= (uint)(Code.Jmp_ptr1632 - Code.Jmp_ptr1616);

		/// <summary>
		/// Checks if it's a <c>CALL NEAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsCallNear(this Code code) =>
			(uint)(code - Code.Call_rel16) <= (uint)(Code.Call_rel32_64 - Code.Call_rel16);

		/// <summary>
		/// Checks if it's a <c>CALL FAR</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsCallFar(this Code code) =>
			(uint)(code - Code.Call_ptr1616) <= (uint)(Code.Call_ptr1632 - Code.Call_ptr1616);

		/// <summary>
		/// Checks if it's a <c>JMP NEAR reg/[mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpNearIndirect(this Code code) =>
			(uint)(code - Code.Jmp_rm16) <= (uint)(Code.Jmp_rm64 - Code.Jmp_rm16);

		/// <summary>
		/// Checks if it's a <c>JMP FAR [mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsJmpFarIndirect(this Code code) =>
			(uint)(code - Code.Jmp_m1616) <= (uint)(Code.Jmp_m1664 - Code.Jmp_m1616);

		/// <summary>
		/// Checks if it's a <c>CALL NEAR reg/[mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsCallNearIndirect(this Code code) =>
			(uint)(code - Code.Call_rm16) <= (uint)(Code.Call_rm64 - Code.Call_rm16);

		/// <summary>
		/// Checks if it's a <c>CALL FAR [mem]</c> instruction
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsCallFarIndirect(this Code code) =>
			(uint)(code - Code.Call_m1616) <= (uint)(Code.Call_m1664 - Code.Call_m1616);

		/// <summary>
		/// Gets the condition code if it's <c>Jcc</c>, <c>SETcc</c>, <c>CMOVcc</c> else <see cref="ConditionCode.None"/> is returned
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		[System.Obsolete("Use " + nameof(ConditionCode) + " instead of this method", true)]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static ConditionCode GetConditionCode(this Code code) => code.ConditionCode();

		/// <summary>
		/// Gets the condition code if it's <c>Jcc</c>, <c>SETcc</c>, <c>CMOVcc</c> else <see cref="ConditionCode.None"/> is returned
		/// </summary>
		/// <param name="code">Code value</param>
		/// <returns></returns>
		public static ConditionCode ConditionCode(this Code code) {
			uint t;

			if ((t = (uint)(code - Code.Jo_rel16)) <= (uint)(Code.Jg_rel32_64 - Code.Jo_rel16) ||
				(t = (uint)(code - Code.Jo_rel8_16)) <= (uint)(Code.Jg_rel8_64 - Code.Jo_rel8_16) ||
				(t = (uint)(code - Code.Cmovo_r16_rm16)) <= (uint)(Code.Cmovg_r64_rm64 - Code.Cmovo_r16_rm16)) {
				return (int)(t / 3) + Data.ConditionCode.o;
			}

			t = (uint)(code - Code.Seto_rm8);
			if (t <= (uint)(Code.Setg_rm8 - Code.Seto_rm8))
				return (int)t + Data.ConditionCode.o;

			return Data.ConditionCode.None;
		}


	}

}