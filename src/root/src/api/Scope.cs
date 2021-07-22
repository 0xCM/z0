//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Scope
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public Scope(string src)
        {
            Name = src;
        }

        public ReadOnlySpan<string> Parts
        {
            [MethodImpl(Inline)]
            get => Name.SplitClean(Chars.Dot);
        }

        public string Format()
            => Name;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Scope(string src)
            => new Scope(src);
    }
}