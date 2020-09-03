//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a specification for producing LSB-oriented masks
    /// </summary>
    /// <typeparam name="F">The repetition frequency type</typeparam>
    /// <typeparam name="D">The bit density type</typeparam>
    /// <typeparam name="T">The mask data type</typeparam>
    public readonly struct LsbMask<F,D,T> : IMaskSpec<F,D,T>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        public const BitMaskKind M = BitMaskKind.Lsb;

        public F f => default;

        public D d => default;

        public T t => default;

        [MethodImpl(Inline)]
        public static implicit operator MaskSpec(LsbMask<F,D,T> src)
            => MaskSpec.define<F,D,T>(M);

        BitMaskKind IMaskSpec.M => M;


        [MethodImpl(Inline)]
        public LsbMask<F,D,S> As<S>(S s = default)
            where S : unmanaged
                => default;

        public override string ToString()
            => (this as ITextual).Format();

    }
}