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

    [StructLayout(LayoutKind.Sequential, Pack =1)]
    public struct ByteBlock1 : IDataBlock<ByteBlock1>
    {
        public static N1 N => default;

        public const ushort Size = Pow2.T00;

        byte A;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        [MethodImpl(Inline)]
        public Span<T> Storage<T>()
            where T : unmanaged
                => recover<T>(Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock1(byte src)
            => @as<uint,ByteBlock1>(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(ByteBlock1 src)
            => @as<ByteBlock1,byte>(src);
    }
}