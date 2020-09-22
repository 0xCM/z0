//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct X86CodeRef
    {
        [MethodImpl(Inline)]
        public static unsafe X86CodeRef create(MemoryAddress @base, ref byte src, ByteSize size)
            => new X86CodeRef(@base, new Ref<byte>(gptr(src), size));

        [MethodImpl(Inline)]
        public static unsafe X86CodeRef create(MemoryAddress @base, ReadOnlySpan<byte> src)
            => new X86CodeRef(@base, new Ref<byte>(gptr(src), (uint)src.Length));

        public readonly MemoryAddress Base;

        public readonly Ref<byte> Ref;

        [MethodImpl(Inline)]
        public X86CodeRef(in MemoryAddress @base, in Ref<byte> src)
        {
            Base = @base;
            Ref = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Ref.IsEmpty;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Ref.Buffer;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Ref.Buffer;
        }

        public BasedCodeBlock Dereference()
            => new BasedCodeBlock(Ref.Address, Ref.Buffer.ToArray());

        public uint Size
        {
            [MethodImpl(Inline)]
            get => Ref.DataSize;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Size;
        }
    }
}