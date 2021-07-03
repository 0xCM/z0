//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct TableColumn
        {
            public string Label {get;}

            public ColumnKind Kind {get;}

            [MethodImpl(Inline)]
            public TableColumn(string label, ColumnKind kind)
            {
                Label = label;
                Kind = kind;
            }
        }

        public enum ColumnKind : byte
        {
            None = 0,

            [Symbol("OpCode")]
            OpCode,

            [Symbol("Instruction")]
            Signature,

            [Symbol("Op/En")]
            EncodingRef,

            [Symbol("CPUID Feature Flag")]
            Cpuid,

            [Symbol("64-bit Mode")]
            Mode64,

            [Symbol("Compat/Leg Mode")]
            Mode32,

            [Symbol("64/32 bit Mode Support")]
            Mode64x32,

            [Symbol("Description")]
            Description,
        }
    }
}