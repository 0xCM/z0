//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Blit;

    public struct bv<T>
        where T : unmanaged
    {
        public uint Width;

        public T Bits;

        [MethodImpl(Inline)]
        public bv(uint width, T bits)
        {
            Width = width;
            Bits = bits;
        }
    }

    public readonly ref struct bv
    {
        readonly Span<bit> Bits;

        [MethodImpl(Inline)]
        public bv(Span<bit> b)
        {
            Bits = b;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => (uint)Bits.Length;
        }

        public ref bit this[long i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bits,i);
        }

        public ref bit this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref seek(Bits,i);
        }

        public string Format()
            => api.format(this);
    }
}