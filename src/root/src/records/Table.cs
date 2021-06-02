//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Table<T> : ITable<T>
        where T : struct, IRecord<T>
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public Table(T[] rows)
        {
            Data = rows;
        }

        public Span<T> Rows
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }
}