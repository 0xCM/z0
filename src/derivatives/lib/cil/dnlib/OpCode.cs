//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{
	using System.Collections.Generic;

    public partial struct DnCilModel
    {
        /// <summary>
        /// A CIL opcode
        /// </summary>
        public sealed class OpCode
        {
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


            /// <inheritdoc/>
            public override string ToString() => Name;
        }
    }
}