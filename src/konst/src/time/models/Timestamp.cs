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

    public readonly struct Timestamp : ITextual
    {
        readonly ulong Ticks;

        [MethodImpl(Inline)]
        internal Timestamp(ulong ticks)
            => Ticks = ticks;        

        [MethodImpl(Inline)]
        public static implicit operator Timestamp(DateTime src)
            => new Timestamp((ulong)src.Ticks);
    
        [MethodImpl(Inline)]
        public string Format()
            => new DateTime((long)Ticks).ToLexicalString();
    }
}