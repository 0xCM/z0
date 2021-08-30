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
        public unsafe struct fx8 : IFunction<fx8,byte,byte>
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
            public byte Eval(byte x)
                => skip(cover(PDst.P, Size), iY(x));

            [MethodImpl(Inline)]
            public map<byte,byte> Map(byte x)
                => api.map(x, Eval(x));
        }

        /// <summary>
        /// Defines a total function over an 8-bit domain
        /// </summary>
        public unsafe struct fx8<S,T> : IFunction<fx8<S,T>,S,T>
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
            public T Eval(S x)
                => skip(cover(PDst.P, Size), iY(u8(x)));

            [MethodImpl(Inline)]
            public map<S,T> Map(S x)
                => api.map(x, Eval(x));
        }
    }
}