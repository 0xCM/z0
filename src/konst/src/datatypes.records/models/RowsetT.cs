//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Rowset<T> : IRowset<T>
        where T : struct, IRecord<T>
    {
        public Index<T> Rows {get;}

        public FS.FilePath Location {get;}

        [MethodImpl(Inline)]
        public Rowset(FS.FilePath location, T[] data)
        {
            Location = location;
            Rows = data;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Rows.Storage;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Rows.View;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Rows.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Rows.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }
    }
}