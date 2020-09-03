//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    /// <summary>
    /// Defines a specification for producing an index-oriented mask
    /// </summary>
    /// <typeparam name="N">The byte-relative bit index</typeparam>
    /// <typeparam name="T">The mask data type</typeparam>
    public readonly struct IndexMask<N,T> : IMaskSpec<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public const BitMaskKind M = BitMaskKind.Index;

        public N n => default;

        BitMaskKind IMaskSpec.M => M;

        public string Format()
            => $"n(f:{value<N>()}, t:{NumericKinds.kind<T>().Format()})";
    }
}
