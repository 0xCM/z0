//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a unit interval
    /// </summary>
    public readonly struct U01<T>
        where T : unmanaged
    {
        public T Left
        {
            [MethodImpl(Inline)]
            get => NumericLiterals.zero<T>();
        }

        public T Right
        {
            [MethodImpl(Inline)]
            get => NumericLiterals.one<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator ClosedInterval<T>(U01<T> src)
            => new ClosedInterval<T>(src.Left, src.Right);
    }
}