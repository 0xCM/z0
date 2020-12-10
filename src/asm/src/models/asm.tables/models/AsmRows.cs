//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRows : IIndex<AsmRow>
    {
        readonly AsmRow[] Data;

        [MethodImpl(Inline)]
        public AsmRows(AsmRow[] src)
            => Data = src;

        public AsmRow[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmRows(AsmRow[] src)
            => new AsmRows(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmRow[](AsmRows src)
            => src.Data;
    }
}