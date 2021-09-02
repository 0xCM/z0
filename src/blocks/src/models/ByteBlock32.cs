//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using B = ByteBlock32;
    using api = ByteBlocks;

    /// <summary>
    /// Covers 32 bytes = 256 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct ByteBlock32 : IStorageBlock<B>
    {
        public const ushort Size = 32;

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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => api.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !api.empty(this);
        }

        [MethodImpl(Inline)]
        public Span<T> Storage<T>()
            where T : unmanaged
                => recover<T>(Bytes);

       [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(B src)
            => vcore.vload(default(W256), src.Bytes);

        [MethodImpl(Inline)]
        public static implicit operator B(Vector256<byte> src)
        {
            var dst = Empty;
            vcore.vstore(src, dst.Bytes);
            return dst;
        }

        public static B Empty => default;
    }
}