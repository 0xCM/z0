//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public ref struct SpanStack<T>
        where T : unmanaged
    {
        readonly Span<T> Buffer;

        readonly int Capacity;

        int Position;

        [MethodImpl(Inline)]
        internal SpanStack(Span<T> buffer)
        {
            Buffer = buffer;
            Capacity = buffer.Length;
            Position = 0;
        }

        [MethodImpl(Inline)]
        public void Push(T src)
        {
            if(Position > MaxPos)
                --Position;

            seek(Head, Position++) = src;
        }

        [MethodImpl(Inline)]
        public ref T Pop()
        {

            if(Position < 0)
                return ref seek(Head, 0);
            else
                return ref seek(Head, --Position);
        }

        ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(Buffer);
        }

        int MaxPos
        {
            [MethodImpl(Inline)]
            get => Capacity - 1;
        }

        public int Enqueued
        {
            [MethodImpl(Inline)]
            get => Position + 1;
        }

        [MethodImpl(Inline)]
        public S Peek<S>()
            where S : unmanaged
                => first(Buffer.Recover<T,S>());
    }
}