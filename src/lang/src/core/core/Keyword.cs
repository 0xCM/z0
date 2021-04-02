//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public interface IKeyword
    {
        Name Name {get;}

        ushort Index {get;}
    }

    public interface IKeyword<L,K> : IKeyword
        where L : struct, ILanguage
        where K : unmanaged
    {
        K Kind {get;}

        ushort IKeyword.Index
            => memory.bw16(Kind);
    }

    /// <summary>
    /// Specifies a keyword
    /// </summary>
    public readonly struct Keyword
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public unsafe Keyword(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public unsafe MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => pchar(Name.Content);
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
        public MemoryAddress Name {get;}

        public A Arg {get;}

        [MethodImpl(Inline)]
        public Keyword(MemoryAddress src, A arg)
        {
            Name = src;
            Arg = arg;
        }
    }
}