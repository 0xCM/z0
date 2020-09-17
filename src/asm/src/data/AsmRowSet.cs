//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRowSet<T>
    {
        public readonly T Key;

        readonly AsmRow[] Rows;

        [MethodImpl(Inline)]
        public static implicit operator AsmRow[](AsmRowSet<T> src)
            => src.Rows;

        [MethodImpl(Inline)]
        public AsmRowSet(T key, AsmRow[] data)
        {
            Key = key;
            Rows = data;
        }

        public AsmRow[] Sequenced
        {
            [MethodImpl(Inline)]
            get => Rows.OrderBy(x => x.Sequence);
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }
    }
}