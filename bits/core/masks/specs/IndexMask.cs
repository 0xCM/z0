//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Defines a specification for producing an index-oriented mask
    /// </summary>
    /// <typeparam name="N">The byte-relative bit index</typeparam>
    /// <typeparam name="T">The mask data type</typeparam>
    public readonly struct IndexMask<N,T> : IMaskSpec<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public const MaskKind M = MaskKind.Index;

        public N n => default;

        MaskKind IMaskSpec.M => M;

        NumericKind IMaskSpec.K 
        {
            [MethodImpl(Inline)]
            get => NumericTypes.kind<T>();
        }

        public string Format()
            => $"n(f:{value<N>()}, t:{Identify.NumericType<T>()})";        
    }
}
