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

    public ref struct BinaryOperators<K,T>
    {
        readonly Span<BinaryOp<T>> Operators;

        byte Offset;

        public BinaryOperators(Span<BinaryOp<T>> src)
        {
            Operators = src;
            Offset = 0;
        }

        public ref BinaryOp<T> this[K index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Operators, u8(index));
        }
    }
}