//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRowSets<T> : IIndex<AsmRowSet<T>>
    {
        readonly Index<AsmRowSet<T>> Data;

        [MethodImpl(Inline)]
        public AsmRowSets(params AsmRowSet<T>[] src)
            => Data = src;

        public ReadOnlySpan<AsmRowSet<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmRowSet<T>[] Storage
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