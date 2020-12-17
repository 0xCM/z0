//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOpCodeDataset
    {
        public TableSpan<AsmOpCodeRow> Entries {get;}

        public TableSpan<AsmOpCodePattern> Identity {get;}

        public AsmOpCodeDataset(AsmOpCodeRow[] records, AsmOpCodePattern[] identifiers)
        {
            Entries = records;
            Identity = identifiers;
        }

        public int OpCodeCount
            => Entries.Length;

        public ref readonly AsmOpCodePattern this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Identity[index];
        }
    }
}