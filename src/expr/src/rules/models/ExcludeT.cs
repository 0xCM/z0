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
    /// Represents a set of exclusions ~(a1 | a2 .. | an)
    /// </summary>
    public readonly struct Exclude<T> : IExpr
    {
        readonly Index<T> _Data;

        [MethodImpl(Inline)]
        public Exclude(Index<T> choices)
            => _Data = choices;

        public uint N
        {
            [MethodImpl(Inline)]
            get => _Data.Count;
        }

        public Label Name
            => "exclude<{0}>";

        public Span<T> Terms
        {
            [MethodImpl(Inline)]
            get => _Data;
        }

        internal T[] Storage
        {
            [MethodImpl(Inline)]
            get => _Data.Storage;
        }

        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Exclude<T>(T[] src)
            => new Exclude<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Exclude(Exclude<T> src)
            => new Exclude(src._Data.Select(x => (dynamic)x));
    }
}