//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops.Logic
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a set of exclusions ~(a1 | a2 .. | an)
    /// </summary>
    public readonly struct Except<T> : ISeqExpr<T>
        where T : IExpr
    {
        readonly Index<T> _Data;

        [MethodImpl(Inline)]
        public Except(Index<T> choices)
            => _Data = choices;

        public uint N
        {
            [MethodImpl(Inline)]
            get => _Data.Count;
        }

        public Label Name
            => "except<{0}>";

        public ReadOnlySpan<T> Terms
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
            => logic.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Except<T>(T[] src)
            => new Except<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Except(Except<T> src)
            => new Except(src.Terms.MapArray(x => (IExpr)x));
    }
}