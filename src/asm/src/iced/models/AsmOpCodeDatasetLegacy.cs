//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeDatasetLegacy
    {
        public Index<AsmOpCodeRowLegacy> Entries {get;}

        public Index<AsmOpCodeExpr> Identity {get;}

        public AsmOpCodeDatasetLegacy(AsmOpCodeRowLegacy[] records, AsmOpCodeExpr[] identifiers)
        {
            Entries = records;
            Identity = identifiers;
        }

        public int OpCodeCount
            => Entries.Length;

        public ref readonly AsmOpCodeExpr this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Identity[index];
        }
    }
}