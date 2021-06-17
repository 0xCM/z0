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
    public struct ByteBlock2 : IDataBlock<ByteBlock2>
    {
        public const ushort Size = Pow2.T01;

        ByteBlock1 A;

        ByteBlock1 B;

        [MethodImpl(Inline)]
        public Span<T> Storage<T>()
            where T : unmanaged
                => recover<T>(Bytes);

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock2(ushort src)
            => @as<ushort,ByteBlock2>(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(ByteBlock2 src)
            => @as<ByteBlock2,ushort>(src);
    }
}