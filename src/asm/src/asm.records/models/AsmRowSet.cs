//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRowSet<T>
    {
        public T Key {get;}

        readonly Index<AsmRow> Rows;

        [MethodImpl(Inline)]
        public AsmRowSet(T key, AsmRow[] data)
        {
            Key = key;
            Rows = data;
        }

        public AsmRow[] Sequenced
        {
            [MethodImpl(Inline)]
            get => Rows.Storage.OrderBy(x => x.Sequence);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Rows.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmRow[](AsmRowSet<T> src)
            => src.Rows.Storage;
    }
}