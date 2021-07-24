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

    using B = ByteBlock128;

    /// <summary>
    /// Covers 128 bytes = 1024 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock128 : IDataBlock<B>
    {
        public const ushort Size = 128;

        ByteBlock64 A;

        ByteBlock64 B;

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