//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a parametric keyword
    /// </summary>
    public readonly struct Keyword<A,B>
    {
        public StringRef Name {get;}

        public A Arg0 {get;}

        public B Arg1 {get;}

        [MethodImpl(Inline)]
        public Keyword(string src, A a, B b)
        {
            Name = src;
            Arg0 = a;
            Arg1 = b;
        }

        [MethodImpl(Inline)]
        public static implicit operator Keyword<A,B>(Tripled<string,A,B> src)
            => new Keyword<A,B>(src.First, src.Second, src.Third);
    }
}