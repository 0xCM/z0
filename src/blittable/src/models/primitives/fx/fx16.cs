//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Blit.Factory;

    partial struct Blit
    {
        /// <summary>
        /// Defines a total function over a 16-bit domain
        /// </summary>
        public unsafe struct fx16<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            readonly Ptr<S> PSrc;

            readonly Ptr<T> PDst;

            internal readonly Index<ushort> SrcMap;

            internal uint Size;

            internal const uint Capacity = ushort.MaxValue + 1;

            [MethodImpl(Inline)]
            internal fx16(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<S>();
                PDst = dst.Pointer<T>();
                SrcMap = alloc<ushort>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly ushort iY(ushort x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public T fx(S x)
                => skip(Target, iY(u16(x)));

            [MethodImpl(Inline)]
            public map<S,T> map(S x)
                => api.map(x, fx(x));

            internal ReadOnlySpan<S> Source
            {
                [MethodImpl(Inline)]
                get => cover(PSrc.P, Size);
            }

            internal ReadOnlySpan<T> Target
            {
                [MethodImpl(Inline)]
                get => cover(PDst.P, Size);
            }
        }

        }
}