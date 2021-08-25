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
        /// Defines a total function over an 8-bit domain
        /// </summary>
        public unsafe struct fx8
        {
            readonly Ptr<byte> PSrc;

            readonly Ptr<byte> PDst;

            internal readonly Index<byte> SrcMap;

            internal uint Size;

            internal const uint Capacity = 256;

            [MethodImpl(Inline)]
            internal fx8(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<byte>();
                PDst = dst.Pointer<byte>();
                SrcMap = alloc<byte>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly byte iY(byte x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public byte fx(byte x)
                => skip(Target, iY(x));

            [MethodImpl(Inline)]
            public map<byte,byte> map(byte x)
                => api.map(x, fx(x));

            internal ReadOnlySpan<byte> Source
            {
                [MethodImpl(Inline)]
                get => cover(PSrc.P, Size);
            }

            internal ReadOnlySpan<byte> Target
            {
                [MethodImpl(Inline)]
                get => cover(PDst.P, Size);
            }
        }


        /// <summary>
        /// Defines a total function over an 8-bit domain
        /// </summary>
        public unsafe struct fx8<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            readonly Ptr<S> PSrc;

            readonly Ptr<T> PDst;

            internal readonly Index<byte> SrcMap;

            internal uint Size;

            internal const uint Capacity = 256;

            [MethodImpl(Inline)]
            internal fx8(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<S>();
                PDst = dst.Pointer<T>();
                SrcMap = alloc<byte>(Capacity);
            }

            [MethodImpl(Inline)]
            ref readonly byte iY(byte x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public T fx(S x)
                => skip(Target, iY(u8(x)));

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