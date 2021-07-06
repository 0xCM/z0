//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public interface IKeyword
    {
        string Name {get;}

        ushort Index {get;}
    }

    public interface IKeyword<L,K> : IKeyword
        where L : struct, ILanguage
        where K : unmanaged
    {
        K Kind {get;}

        ushort IKeyword.Index
            => bw16(Kind);
    }

    /// <summary>
    /// Specifies a keyword
    /// </summary>
    public readonly struct Keyword
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public unsafe Keyword(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public unsafe ulong Address
        {
            [MethodImpl(Inline)]
            get => (ulong)pchar(Name);
        }

        [MethodImpl(Inline)]
        public static implicit operator Keyword(string name)
            => new Keyword(name);
    }

    /// <summary>
    /// Defines a parametric keyword
    /// </summary>
    public readonly struct Keyword<A>
    {
        public ulong Name {get;}

        public A Arg {get;}

        [MethodImpl(Inline)]
        public Keyword(ulong src, A arg)
        {
            Name = src;
            Arg = arg;
        }
    }
}