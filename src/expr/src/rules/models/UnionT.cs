//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a sequence of parametrically-typed terms c0 | c1 | .. | cN-1
    /// </summary>
    public readonly struct Union<T> : IUnion<T>
    {
        readonly Index<T> _Data;

        [MethodImpl(Inline)]
        public Union(Index<T> choices)
            => _Data = choices;

        public uint N
        {
            [MethodImpl(Inline)]
            get => _Data.Count;
        }

        public Label Name => "union<{0}>";

        public Span<T> Terms
        {
            [MethodImpl(Inline)]
            get => _Data;
        }

        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Union<T>(T[] src)
            => new Union<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Union(Union<T> src)
            => new Union(src._Data.Select(x => (dynamic)x));
    }
}