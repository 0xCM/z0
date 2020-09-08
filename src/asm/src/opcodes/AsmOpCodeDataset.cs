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
        public readonly TableSpan<AsmOpCodeTable> Entries;

        public readonly TableSpan<AsmOpCodeId> Identity;

        public AsmOpCodeDataset(AsmOpCodeTable[] records, AsmOpCodeId[] identifiers)
        {
            Entries = records;
            Identity = identifiers;
        }

        public int OpCodeCount
            => Entries.Length;

        public ref readonly AsmOpCodeId this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Identity[index];
        }
    }
}