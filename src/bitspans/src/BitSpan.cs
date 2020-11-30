//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    using api = BitSpans;

    public readonly ref struct BitSpan
    {
        readonly Span<bit> Data;

        [MethodImpl(Inline)]
        public BitSpan(Span<bit> src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint BitCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref bit this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,index);
        }

        public ref bit this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,index);
        }

        public ref bit First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        internal Span<bit> Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static bit operator ==(in BitSpan x, in BitSpan y)
            => api.same(x,y);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitSpan x, in BitSpan y)
            => !api.same(x,y);

        public static BitSpan Empty => default;

        public override bool Equals(object obj)
            => throw missing();

        public override int GetHashCode()
            => throw missing();
    }
}