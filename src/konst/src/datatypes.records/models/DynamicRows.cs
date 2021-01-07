//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a <see cref='DynamicRow{T}'/> sequence
    /// </summary>
    public readonly struct DynamicRows<T> : IIndex<DynamicRow<T>>
        where T : struct
    {
        readonly Index<DynamicRow<T>> Data;

        [MethodImpl(Inline)]
        public DynamicRows(Index<DynamicRow<T>> src)
            => Data = src;

        public DynamicRow<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<DynamicRow<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<DynamicRow<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Rowset<DynamicRow<T>> Rowset
        {
            [MethodImpl(Inline)]
            get => new Rowset<DynamicRow<T>>(Data);
        }

        public ref DynamicRow<T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(int)index];
        }

        public ref DynamicRow<T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(int)index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator DynamicRows<T>(DynamicRow<T>[] data)
            => new DynamicRows<T>(data);

        public static DynamicRows<T> Empty
        {
            [MethodImpl(Inline)]
            get => sys.empty<DynamicRow<T>>();
        }
    }
}