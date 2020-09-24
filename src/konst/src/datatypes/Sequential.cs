//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct Sequential : ITextual
    {
        public uint Value;

        [MethodImpl(Inline)]
        public static Sequential operator ++(Sequential src)
            => new Sequential(++src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Sequential(uint src)
            => new Sequential(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Sequential src)
            => src.Value;

        [MethodImpl(Inline)]
        public Sequential(uint src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}