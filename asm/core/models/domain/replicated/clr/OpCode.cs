//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.ClrSpecs
{        
	using System.Collections.Generic;
	/// <summary>
	/// A CIL opcode
	/// </summary>
	public sealed class OpCode {
		/// <summary>
		/// The opcode name
		/// </summary>
		public readonly string Name;

		/// <summary>
		/// The opcode as a <see cref="Code"/> enum
		/// </summary>
		public readonly Code Code;

		/// <summary>
		/// Operand type
		/// </summary>
		public readonly OperandType OperandType;

		/// <summary>
		/// Flow control info
		/// </summary>
		public readonly FlowControl FlowControl;

		/// <summary>
		/// Opcode type
		/// </summary>
		public readonly OpCodeType OpCodeType;

		/// <summary>
		/// Push stack behavior
		/// </summary>
		public readonly StackBehaviour StackBehaviourPush;

		/// <summary>
		/// Pop stack behavior
		/// </summary>
		public readonly StackBehaviour StackBehaviourPop;

		/// <summary>
		/// Gets the value which is compatible with <see cref="System.Reflection.Emit.OpCode.Value"/>
		/// </summary>
		public short Value => (short)Code;

		/// <summary>
		/// Gets the size of the opcode. It's either 1 or 2 bytes.
		/// </summary>
		public int Size => Code < (Code)0x100 || Code == Code.UNKNOWN1 ? 1 : 2;

		public OpCode(string name, Code code, OperandType operandType, FlowControl flowControl, OpCodeType opCodeType, StackBehaviour push, StackBehaviour pop) {
			Name = name;
			Code = code;
			OperandType = operandType;
			FlowControl = flowControl;
			OpCodeType = opCodeType;
			StackBehaviourPush = push;
			StackBehaviourPop = pop;
			if (((ushort)code >> 8) == 0)
				OpCodes.OneByteOpCodes[(byte)code] = this;
			else if (((ushort)code >> 8) == 0xFE)
				OpCodes.TwoByteOpCodes[(byte)code] = this;
		}

		/// <summary>
		/// Creates a new instruction with no operand
		/// </summary>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction() => Instruction.Create(this);

		/// <summary>
		/// Creates a new instruction with a <see cref="byte"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(byte value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with a <see cref="sbyte"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(sbyte value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with an <see cref="int"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(int value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with a <see cref="long"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(long value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with a <see cref="float"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(float value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with a <see cref="double"/> operand
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(double value) => Instruction.Create(this, value);

		/// <summary>
		/// Creates a new instruction with a string operand
		/// </summary>
		/// <param name="s">The string</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(string s) => Instruction.Create(this, s);

		/// <summary>
		/// Creates a new instruction with an instruction target operand
		/// </summary>
		/// <param name="target">Target instruction</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(Instruction target) => Instruction.Create(this, target);

		/// <summary>
		/// Creates a new instruction with an instruction target list operand
		/// </summary>
		/// <param name="targets">The targets</param>
		/// <returns>A new <see cref="Instruction"/> instance</returns>
		public Instruction ToInstruction(IList<Instruction> targets) => Instruction.Create(this, targets);

		/// <inheritdoc/>
		public override string ToString() => Name;

    }

}