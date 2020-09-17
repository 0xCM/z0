//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct DnCilModel
    {
        /// <summary>
        /// A CIL instruction (opcode + operand)
        /// </summary>
        public struct Instruction : ITextual
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

            [MethodImpl(Inline)]
            public Instruction(OpCode opCode, object operand, uint offset, string formatted)
            {
                OpCode = opCode;
                Operand = operand;
                Offset = offset;
                Formatted = formatted;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Formatted;

            public override string ToString()
                => Formatted;
        }
    }
}