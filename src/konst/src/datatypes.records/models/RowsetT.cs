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
    /// Defines a <typeparamref name='T'/> row index
    /// </summary>
    public readonly struct Rowset<T> : IIndex<T>
        where T : struct
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public Rowset(T[] data)
            => Data = data;

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}