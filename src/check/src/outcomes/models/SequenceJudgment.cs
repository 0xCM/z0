//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct SequenceJudgement
    {
        [MethodImpl(NotInline)]
        public static SequenceJudgement<T> alloc<T>(uint count, bit result)
            => new SequenceJudgement<T>(new BinaryJudgement<T>[count], result);
    }

    public struct SequenceJudgement<T> : ISequenceJudgement<SequenceJudgement<T>,BinaryJudgement<T>>
    {
        readonly BinaryJudgement<T>[] Data;

        public bit Result;

        [MethodImpl(Inline)]
        internal SequenceJudgement(BinaryJudgement<T>[] src, bit result)
        {
            Result = result;
            Data = src;
        }

        public ref BinaryJudgement<T> First
        {
            [MethodImpl(Inline)]
            get => ref first(span(Data));
        }

        public ref BinaryJudgement<T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First, index);
        }

        public ref BinaryJudgement<T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First, (ulong)index);
        }

        public ReadOnlySpan<BinaryJudgement<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<BinaryJudgement<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public BinaryJudgement<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        bit IJudgement.Result
            => Result;

        [MethodImpl(Inline)]
        public static bool operator true(SequenceJudgement<T> src)
            => src.Result;

        [MethodImpl(Inline)]
        public static bool operator false(SequenceJudgement<T> src)
            => !src.Result;
    }
}