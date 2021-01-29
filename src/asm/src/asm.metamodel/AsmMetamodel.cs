//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct AsmMetamodel
    {
        /// <summary>
        /// Characterizes a function that produces a statement
        /// </summary>
        public readonly struct StatementFactory
        {
            public AsmSpecInfo SpecInfo {get;}
        }

        /// <summary>
        /// Characterizes a model of an operand
        /// </summary>
        public readonly struct OperandInfo
        {
            /// <summary>
            /// The basic operand classification - imm, reg or mem
            /// </summary>
            public AsmOperandKind Kind {get;}

            /// <summary>
            /// The operand bit-widht
            /// </summary>
            public TypeWidth Width {get;}
        }

        public readonly struct AsmDataType
        {

        }
    }
}