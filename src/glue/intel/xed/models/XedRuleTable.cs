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
        /// <summary>
        /// Captures data given in the form '{Sequence} {IClass} {IForm} {Category} {Extension} {Isa} ATTRIBUTES: (Attributes)*'
        /// </summary>
        public struct HeaderRow
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

            public OperandCategory Category;

            public OperandModifier Modifier;

            public OperandType Type;
        }

        public HeaderRow Header;

        public byte OperandCount;

        public OperandRow Op1;

        public OperandRow Op2;

        public OperandRow Op3;

        public OperandRow Op4;

    }
}