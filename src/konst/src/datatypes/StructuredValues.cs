//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

   public readonly struct StructuredValues<T> : IValues<StructuredValues<T>, T>
        where T : struct
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public StructuredValues(T[] src)
        {
            Data = src;
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


        ref T this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Edit[(int)index];
        }

        ref T this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Edit[(int)index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ByteSize TotalSize
        {
            [MethodImpl(Inline)]
            get => Count*size<T>();
        }
    }
}