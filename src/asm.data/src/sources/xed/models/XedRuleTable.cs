//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static XedModels;

    public struct XedRuleTable
    {
        public enum TableRowKind : byte
        {
            None,

            Instruction,

            OpCount,

            Operand,

            Comment,
        }

        public readonly ref struct TableRow
        {
            public TableRowKind Kind {get;}

            readonly AsciLine Data;

            [MethodImpl(Inline)]
            public TableRow(TableRowKind kind, AsciLine data)
            {
                Kind = kind;
                Data = data;
            }

            public LineNumber LineNumber
            {
                [MethodImpl(Inline)]
                get => Data.LineNumber;
            }

            public static TableRow Empty
            {
                [MethodImpl(Inline)]
                get => new TableRow(0,AsciLine.Empty);
            }
        }

        /// <summary>
        /// Captures data given in the form '{Sequence} {IClass} {IForm} {Category} {Extension} {Isa} ATTRIBUTES: (Attributes)*'
        /// </summary>
        public struct InstructionRow
        {
            /// <summary>
            /// Surrogate key
            /// </summary>
            public ushort Sequence;

            /// <summary>
            /// The instruction class
            /// </summary>
            public IClass Class;

            /// <summary>
            /// The instruction form
            /// </summary>
            public IForm Form;

            public Category Category;

            public Extension Extension;

            public IsaKind Isa;

            public AttributeVector Attributes;
        }

        public struct OperandRow
        {
            public OperandIndex Index;

            public OperandKind Kind;

            public OperandVisibility Visibility;

            public LookupKind Category;

            public OperandAction Action;

            public DataType Type;
        }

        public InstructionRow Instruction;

        public byte OpCount;

        public OperandRow Op1;

        public OperandRow Op2;

        public OperandRow Op3;

        public OperandRow Op4;
    }
}