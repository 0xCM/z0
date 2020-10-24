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

    public readonly struct RuleEffect<T>
    {
        public T[] Data {get;}

        [MethodImpl(Inline)]
        public RuleEffect(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator RuleEffect<T>(T[] src)
            => new RuleEffect<T>(src);
    }
}