//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = AsmOperatorKind;

    public readonly struct AsmOperator
    {
        public AsmOperatorKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmOperator(AsmOperatorKind kind)
        {
            Kind = kind;
        }
    }

    public enum AsmOperatorKind : byte
    {
        None  = 0,

        [Symbol("+")]
        Add,

        [Symbol("-")]
        Sub
    }

    public sealed class AsmOperatorTable : StringTable<AsmOperatorTable>
    {
        static AsmOperatorTable()
        {
            Entries = core.alloc<string>(3);
            var i=0;
            Entries[i++] = nameof(K.None);
            Entries[i++] = nameof(K.Add);
            Entries[i++] = nameof(K.Sub);
        }

    }
}