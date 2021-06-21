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

    /// <summary>
    /// Covers 32 bytes = 256 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock32 : IDataBlock<ByteBlock32>
    {
        public const ushort Size = Pow2.T05;

        public static N32 N => default;

        ByteBlock16 A;

        ByteBlock16 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ByteBlock16 Lo
        {
            [MethodImpl(Inline)]
            get => A;
        }

        public ByteBlock16 Hi
        {
            [MethodImpl(Inline)]
            get => B;
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

        public static ByteBlock32 Empty => default;
    }
}