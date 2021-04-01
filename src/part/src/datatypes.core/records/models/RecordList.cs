//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using System.Collections;

    public readonly struct RecordList
    {
        public static RecordList<T> create<T>(uint capacity = 128)
            where T : struct, IRecord<T>
                => new RecordList<T>(capacity);
    }

    public class RecordList<T> : IEnumerable<T>
        where T : struct, IRecord<T>
    {
        readonly List<T> Storage;

        public RecordList()
        {
            Storage = new List<T>(128);
        }

        public RecordList(uint capacity)
        {
            Storage = new List<T>((int)capacity);
        }

        public RecordList(T[] src)
        {
            Storage = new List<T>(src.Length);
            Storage.AddRange(src);
        }

        [MethodImpl(Inline)]
        public void Add(T src)
        {
            Storage.Add(src);
        }

        [MethodImpl(Inline)]
        public void Add(ReadOnlySpan<T> src)
        {
            root.iter(src,Add);
        }

        [MethodImpl(Inline)]
        public void Add(T[] src)
        {
            Storage.AddRange(src);
        }

        [MethodImpl(Inline)]
        public void Add(Index<T> src)
        {
            Storage.AddRange(src.Storage);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Storage.Count;
        }

        [MethodImpl(Inline)]
        public Index<T> Emit(bool clear = true)
        {
            var data = Storage.ToArray();
            Storage.Clear();
            return data;
        }

        public IReadOnlyList<T> Items
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => ((IEnumerable)Storage).GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => ((IEnumerable<T>)Storage).GetEnumerator();


        [MethodImpl(Inline)]
        public static implicit operator RecordList<T>(T[] src)
            => new RecordList<T>(src);

        public static RecordList<T> Empty
        {
            [MethodImpl(Inline)]
            get => sys.empty<T>();
        }
    }
}