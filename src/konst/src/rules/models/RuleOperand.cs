//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RuleOperand<T>
    {
        public T[] Data {get;}

        [MethodImpl(Inline)]
        public RuleOperand(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator RuleOperand<T>(T[] src)
            => new RuleOperand<T>(src);
    }
}