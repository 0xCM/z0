//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock4 : IDataBlock<ByteBlock4>
    {
        public const ushort Size = Pow2.T02;

        ByteBlock2 A;

        ByteBlock2 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }

        [MethodImpl(Inline)]
        public Span<T> Storage<T>()
            where T : unmanaged
                => recover<T>(Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock4(uint src)
            => @as<uint,ByteBlock4>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteBlock4 src)
            => @as<ByteBlock4,uint>(src);
    }
}