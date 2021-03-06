//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiKeyword
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public unsafe ApiKeyword(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public unsafe MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => core.pchar(Name.Content);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiKeyword(string name)
            => new ApiKeyword(name);
    }

    /// <summary>
    /// Defines a parametric keyword
    /// </summary>
    public readonly struct ApiKeyword<A>
    {
        public MemoryAddress Name {get;}

        public A Arg {get;}

        [MethodImpl(Inline)]
        public ApiKeyword(MemoryAddress src, A arg)
        {
            Name = src;
            Arg = arg;
        }
    }
}