//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRowSets<T>
    {
        readonly AsmRowSet<T>[] Data;

        [MethodImpl(Inline)]
        public AsmRowSets(params AsmRowSet<T>[] src)
            => Data = src;

        public ReadOnlySpan<AsmRowSet<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}