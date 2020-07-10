//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.CilSpecs
{        
    using System;
    using System.Collections.Generic;

	/// <summary>
	/// A CIL instruction (opcode + operand)
	/// </summary>
	public sealed class Instruction 
    {
		/// <summary>
		/// The opcode
		/// </summary>
		public OpCode OpCode;

		/// <summary>
		/// The opcode operand
		/// </summary>
		public object Operand;

		/// <summary>
		/// Offset of the instruction in the method body
		/// </summary>
		public uint Offset;

		public string Formatted;

		public override string ToString()
			=> Formatted;

		public Instruction()
		{

		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="opCode">Opcode</param>
		public Instruction(OpCode opCode) => OpCode = opCode;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="opCode">Opcode</param>
		/// <param name="operand">The operand</param>
		public Instruction(OpCode opCode, object operand) {
			OpCode = opCode;
			Operand = operand;
		}

		/// <summary>
		/// Clone this instance. The <see cref="Operand"/> and <see cref="SequencePoint"/> fields
		/// are shared by this instance and the created instance.
		/// </summary>
		public Instruction Clone() =>
			new Instruction {
				Offset = Offset,
				OpCode = OpCode,
				Operand = Operand,
			};

		/// <summary>
		/// Creates a new instruction with no operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode) {
			if (opCode.OperandType != OperandType.InlineNone)
				throw new ArgumentException("Must be a no-operand opcode", nameof(opCode));
			return new Instruction(opCode);
		}

		/// <summary>
		/// Creates a new instruction with a <see cref="byte"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, byte value) {
			if (opCode.Code != Code.Unaligned)
				throw new ArgumentException("Opcode does not have a byte operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with a <see cref="sbyte"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, sbyte value) {
			if (opCode.Code != Code.Ldc_I4_S)
				throw new ArgumentException("Opcode does not have a sbyte operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with an <see cref="int"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, int value) {
			if (opCode.OperandType != OperandType.InlineI)
				throw new ArgumentException("Opcode does not have an int32 operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with a <see cref="long"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, long value) {
			if (opCode.OperandType != OperandType.InlineI8)
				throw new ArgumentException("Opcode does not have an int64 operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with a <see cref="float"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, float value) {
			if (opCode.OperandType != OperandType.ShortInlineR)
				throw new ArgumentException("Opcode does not have a real4 operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with a <see cref="double"/> operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, double value) {
			if (opCode.OperandType != OperandType.InlineR)
				throw new ArgumentException("Opcode does not have a real8 operand", nameof(opCode));
			return new Instruction(opCode, value);
		}

		/// <summary>
		/// Creates a new instruction with a string operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="s">The string</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, string s) {
			if (opCode.OperandType != OperandType.InlineString)
				throw new ArgumentException("Opcode does not have a string operand", nameof(opCode));
			return new Instruction(opCode, s);
		}

		/// <summary>
		/// Creates a new instruction with an instruction target operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="target">Target instruction</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, Instruction target) {
			if (opCode.OperandType != OperandType.ShortInlineBrTarget && opCode.OperandType != OperandType.InlineBrTarget)
				throw new ArgumentException("Opcode does not have an instruction operand", nameof(opCode));
			return new Instruction(opCode, target);
		}

		/// <summary>
		/// Creates a new instruction with an instruction target list operand
		/// </summary>
		/// <param name="opCode">The opcode</param>
		/// <param name="targets">The targets</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction Create(OpCode opCode, IList<Instruction> targets) {
			if (opCode.OperandType != OperandType.InlineSwitch)
				throw new ArgumentException("Opcode does not have a targets array operand", nameof(opCode));
			return new Instruction(opCode, targets);
		}

		/// <summary>
		/// Creates a <c>ldci4</c> instruction
		/// </summary>
		/// <param name="value">Operand value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public static Instruction CreateLdcI4(int value) {
			switch (value) {
			case -1:return OpCodes.Ldc_I4_M1.ToInstruction();
			case 0: return OpCodes.Ldc_I4_0.ToInstruction();
			case 1: return OpCodes.Ldc_I4_1.ToInstruction();
			case 2: return OpCodes.Ldc_I4_2.ToInstruction();
			case 3: return OpCodes.Ldc_I4_3.ToInstruction();
			case 4: return OpCodes.Ldc_I4_4.ToInstruction();
			case 5: return OpCodes.Ldc_I4_5.ToInstruction();
			case 6: return OpCodes.Ldc_I4_6.ToInstruction();
			case 7: return OpCodes.Ldc_I4_7.ToInstruction();
			case 8: return OpCodes.Ldc_I4_8.ToInstruction();
			}
			if (sbyte.MinValue <= value && value <= sbyte.MaxValue)
				return new Instruction(OpCodes.Ldc_I4_S, (sbyte)value);
			return new Instruction(OpCodes.Ldc_I4, value);
		}


		/// <summary>
		/// Gets the size in bytes of the instruction
		/// </summary>
		/// <returns></returns>
		public int GetSize() {
			var opCode = OpCode;
			switch (opCode.OperandType) {
			case OperandType.InlineBrTarget:
			case OperandType.InlineField:
			case OperandType.InlineI:
			case OperandType.InlineMethod:
			case OperandType.InlineSig:
			case OperandType.InlineString:
			case OperandType.InlineTok:
			case OperandType.InlineType:
			case OperandType.ShortInlineR:
				return opCode.Size + 4;

			case OperandType.InlineI8:
			case OperandType.InlineR:
				return opCode.Size + 8;

			case OperandType.InlineNone:
			case OperandType.InlinePhi:
			default:
				return opCode.Size;

			case OperandType.InlineSwitch:
				var targets = Operand as IList<Instruction>;
				return opCode.Size + 4 + (targets is null ? 0 : targets.Count * 4);

			case OperandType.InlineVar:
				return opCode.Size + 2;

			case OperandType.ShortInlineBrTarget:
			case OperandType.ShortInlineI:
			case OperandType.ShortInlineVar:
				return opCode.Size + 1;
			}
		}

		void CalculateStackUsageNonCall(OpCode opCode, bool hasReturnValue, out int pushes, out int pops) {
			switch (opCode.StackBehaviourPush) {
			case StackBehaviour.Push0:
				pushes = 0;
				break;

			case StackBehaviour.Push1:
			case StackBehaviour.Pushi:
			case StackBehaviour.Pushi8:
			case StackBehaviour.Pushr4:
			case StackBehaviour.Pushr8:
			case StackBehaviour.Pushref:
				pushes = 1;
				break;

			case StackBehaviour.Push1_push1:
				pushes = 2;
				break;

			case StackBehaviour.Varpush:	// only call, calli, callvirt which are handled elsewhere
			default:
				pushes = 0;
				break;
			}

			switch (opCode.StackBehaviourPop) {
			case StackBehaviour.Pop0:
				pops = 0;
				break;

			case StackBehaviour.Pop1:
			case StackBehaviour.Popi:
			case StackBehaviour.Popref:
				pops = 1;
				break;

			case StackBehaviour.Pop1_pop1:
			case StackBehaviour.Popi_pop1:
			case StackBehaviour.Popi_popi:
			case StackBehaviour.Popi_popi8:
			case StackBehaviour.Popi_popr4:
			case StackBehaviour.Popi_popr8:
			case StackBehaviour.Popref_pop1:
			case StackBehaviour.Popref_popi:
				pops = 2;
				break;

			case StackBehaviour.Popi_popi_popi:
			case StackBehaviour.Popref_popi_popi:
			case StackBehaviour.Popref_popi_popi8:
			case StackBehaviour.Popref_popi_popr4:
			case StackBehaviour.Popref_popi_popr8:
			case StackBehaviour.Popref_popi_popref:
			case StackBehaviour.Popref_popi_pop1:
				pops = 3;
				break;

			case StackBehaviour.PopAll:
				pops = -1;
				break;

			case StackBehaviour.Varpop:	// call, calli, callvirt, newobj (all handled elsewhere), and ret
				if (hasReturnValue)
					pops = 1;
				else
					pops = 0;
				break;

			default:
				pops = 0;
				break;
			}
		}

		/// <summary>
		/// Checks whether it's one of the <c>leave</c> instructions
		/// </summary>
		public bool IsLeave() => OpCode == OpCodes.Leave || OpCode == OpCodes.Leave_S;

		/// <summary>
		/// Checks whether it's one of the <c>br</c> instructions
		/// </summary>
		public bool IsBr() => OpCode == OpCodes.Br || OpCode == OpCodes.Br_S;

		/// <summary>
		/// Checks whether it's one of the <c>brfalse</c> instructions
		/// </summary>
		public bool IsBrfalse() => OpCode == OpCodes.Brfalse || OpCode == OpCodes.Brfalse_S;

		/// <summary>
		/// Checks whether it's one of the <c>brtrue</c> instructions
		/// </summary>
		public bool IsBrtrue() => OpCode == OpCodes.Brtrue || OpCode == OpCodes.Brtrue_S;

		/// <summary>
		/// Checks whether it's one of the conditional branch instructions (bcc, brtrue, brfalse)
		/// </summary>
		public bool IsConditionalBranch() {
			switch (OpCode.Code) {
			case Code.Bge:
			case Code.Bge_S:
			case Code.Bge_Un:
			case Code.Bge_Un_S:
			case Code.Blt:
			case Code.Blt_S:
			case Code.Blt_Un:
			case Code.Blt_Un_S:
			case Code.Bgt:
			case Code.Bgt_S:
			case Code.Bgt_Un:
			case Code.Bgt_Un_S:
			case Code.Ble:
			case Code.Ble_S:
			case Code.Ble_Un:
			case Code.Ble_Un_S:
			case Code.Brfalse:
			case Code.Brfalse_S:
			case Code.Brtrue:
			case Code.Brtrue_S:
			case Code.Beq:
			case Code.Beq_S:
			case Code.Bne_Un:
			case Code.Bne_Un_S:
				return true;

			default:
				return false;
			}
		}

		/// <summary>
		/// Checks whether this is one of the <c>ldc.i4</c> instructions
		/// </summary>
		public bool IsLdcI4() {
			switch (OpCode.Code) {
			case Code.Ldc_I4_M1:
			case Code.Ldc_I4_0:
			case Code.Ldc_I4_1:
			case Code.Ldc_I4_2:
			case Code.Ldc_I4_3:
			case Code.Ldc_I4_4:
			case Code.Ldc_I4_5:
			case Code.Ldc_I4_6:
			case Code.Ldc_I4_7:
			case Code.Ldc_I4_8:
			case Code.Ldc_I4_S:
			case Code.Ldc_I4:
				return true;
			default:
				return false;
			}
		}

		/// <summary>
		/// Returns a <c>ldc.i4</c> instruction's operand
		/// </summary>
		/// <returns>The integer value</returns>
		/// <exception cref="InvalidOperationException"><see cref="OpCode"/> isn't one of the
		/// <c>ldc.i4</c> opcodes</exception>
		public int GetLdcI4Value() {
			switch (OpCode.Code) {
			case Code.Ldc_I4_M1:return -1;
			case Code.Ldc_I4_0:	return 0;
			case Code.Ldc_I4_1:	return 1;
			case Code.Ldc_I4_2:	return 2;
			case Code.Ldc_I4_3:	return 3;
			case Code.Ldc_I4_4:	return 4;
			case Code.Ldc_I4_5:	return 5;
			case Code.Ldc_I4_6:	return 6;
			case Code.Ldc_I4_7:	return 7;
			case Code.Ldc_I4_8:	return 8;
			case Code.Ldc_I4_S:	return (sbyte)Operand;
			case Code.Ldc_I4:	return (int)Operand;
			default:
				throw new InvalidOperationException($"Not a ldc.i4 instruction: {this}");
			}
		}

		/// <summary>
		/// Checks whether it's one of the <c>ldarg</c> instructions, but does <c>not</c> check
		/// whether it's one of the <c>ldarga</c> instructions.
		/// </summary>
		public bool IsLdarg() {
			switch (OpCode.Code) {
			case Code.Ldarg:
			case Code.Ldarg_S:
			case Code.Ldarg_0:
			case Code.Ldarg_1:
			case Code.Ldarg_2:
			case Code.Ldarg_3:
				return true;
			default:
				return false;
			}
		}

		/// <summary>
		/// Checks whether it's one of the <c>ldloc</c> instructions, but does <c>not</c> check
		/// whether it's one of the <c>ldloca</c> instructions.
		/// </summary>
		public bool IsLdloc() {
			switch (OpCode.Code) {
			case Code.Ldloc:
			case Code.Ldloc_0:
			case Code.Ldloc_1:
			case Code.Ldloc_2:
			case Code.Ldloc_3:
			case Code.Ldloc_S:
				return true;
			default:
				return false;
			}
		}

		/// <summary>
		/// Checks whether it's one of the <c>starg</c> instructions
		/// </summary>
		public bool IsStarg() {
			switch (OpCode.Code) {
			case Code.Starg:
			case Code.Starg_S:
				return true;
			default:
				return false;
			}
		}

		/// <summary>
		/// Checks whether it's one of the <c>stloc</c> instructions
		/// </summary>
		public bool IsStloc() {
			switch (OpCode.Code) {
			case Code.Stloc:
			case Code.Stloc_0:
			case Code.Stloc_1:
			case Code.Stloc_2:
			case Code.Stloc_3:
			case Code.Stloc_S:
				return true;
			default:
				return false;
			}
		}
    }

	static partial class Extensions {
		/// <summary>
		/// Gets the opcode or <see cref="OpCodes.UNKNOWN1"/> if <paramref name="self"/> is <c>null</c>
		/// </summary>
		/// <param name="self">this</param>
		/// <returns></returns>
		public static OpCode GetOpCode(this Instruction self) => self?.OpCode ?? OpCodes.UNKNOWN1;

		/// <summary>
		/// Gets the operand or <c>null</c> if <paramref name="self"/> is <c>null</c>
		/// </summary>
		/// <param name="self">this</param>
		/// <returns></returns>
		public static object GetOperand(this Instruction self) => self?.Operand;

		/// <summary>
		/// Gets the offset or 0 if <paramref name="self"/> is <c>null</c>
		/// </summary>
		/// <param name="self">this</param>
		/// <returns></returns>
		public static uint GetOffset(this Instruction self) => self?.Offset ?? 0;

		/// <summary>
		/// Converts a <see cref="Code"/> to an <see cref="OpCode"/>
		/// </summary>
		/// <param name="code">The code</param>
		/// <returns>A <see cref="OpCode"/> or <c>null</c> if it's invalid</returns>
		public static OpCode ToOpCode(this Code code) {
			int hi = (ushort)code >> 8;
			int lo = (byte)code;
			if (hi == 0)
				return OpCodes.OneByteOpCodes[lo];
			if (hi == 0xFE)
				return OpCodes.TwoByteOpCodes[lo];
			if (code == Code.UNKNOWN1)
				return OpCodes.UNKNOWN1;
			if (code == Code.UNKNOWN2)
				return OpCodes.UNKNOWN2;
			return null;
		}

    }
}