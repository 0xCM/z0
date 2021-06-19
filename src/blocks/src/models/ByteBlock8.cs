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
    public struct ByteBlock8 : IDataBlock<ByteBlock8>
    {
        public const ushort Size = Pow2.T03;

        ByteBlock4 A;

        ByteBlock4 B;

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
        public static implicit operator ByteBlock8(ulong src)
            => @as<ulong,ByteBlock8>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(ByteBlock8 src)
            => @as<ByteBlock8,ulong>(src);
    }
}