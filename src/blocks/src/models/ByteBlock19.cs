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

    using B = ByteBlock19;


    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock19 : IDataBlock<ByteBlock19>
    {
        public const ushort Size = 19;

        ByteBlock16 A;

        ByteBlock3 B;

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

        public static ByteBlock19 Empty => default;
    }
}