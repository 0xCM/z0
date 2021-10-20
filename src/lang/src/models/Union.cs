//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a sequence of dynamically-typed terms c0 | c1 | .. | cN-1
    /// </summary>
    public readonly struct Union : IUnion
    {
        public Index<dynamic> Terms {get;}

        [MethodImpl(Inline)]
        public Union(Index<dynamic> choices)
            => Terms = choices;

        public uint N
        {
            [MethodImpl(Inline)]
            get => Terms.Count;
        }

        public Label Name => "union";

        public string Format()
            => lang.format(this);

        public override string ToString()
            => Format();
    }
}