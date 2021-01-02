//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOpCodeRows : IIndex<AsmOpCodeRow>
    {
        readonly Index<AsmOpCodeRow> Data;

        [MethodImpl(Inline)]
        public AsmOpCodeRows(AsmOpCodeRow[] src)
            => Data = src;

        public AsmOpCodeRow[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

            [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeRows(AsmOpCodeRow[] src)
            => new AsmOpCodeRows(src);
    }
}