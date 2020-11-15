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

    /// <summary>
    /// Defines an item selection
    /// </summary>
    public readonly struct SymbolicChoice<T> : ISymbolicChoice<SymbolicChoice<T>,T>
        where T : unmanaged
    {
        public T Chosen {get;}

        [MethodImpl(Inline)]
        public SymbolicChoice(T chosen)
            => Chosen = chosen;

        [MethodImpl(Inline)]
        public static implicit operator SymbolicChoice<T>(T src)
            => new SymbolicChoice<T>(src);
    }
}