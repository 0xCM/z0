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

    using B = ByteBlock64;

    /// <summary>
    /// Covers 64 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock64 : IDataBlock<B>
    {
        public const ushort Size = 64;

        ByteBlock32 A;

        ByteBlock32 B;

        [MethodImpl(Inline)]
        public ByteBlock64(ByteBlock32 a, ByteBlock32 b)
        {
            A = a;
            B = b;
        }

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

        public static B Empty => default;
    }
}