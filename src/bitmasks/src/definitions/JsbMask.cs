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
    /// Defines a specification for producing joint lsb/msb mask compositions
    /// </summary>
    /// <typeparam name="F">The repetition frequency type</typeparam>
    /// <typeparam name="D">The bit density type</typeparam>
    /// <typeparam name="T">The mask data type</typeparam>
    public readonly struct JsbMask<F,D,T> : IMaskSpec<F,D,T>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        public const MaskKind M = MaskKind.Jsb;

        public F f => default;

        public D d => default;

        public T t => default;

        [MethodImpl(Inline)]
        public static implicit operator MaskSpec(JsbMask<F,D,T> src)
            => MaskSpec.Define<F,D,T>(M);

        MaskKind IMaskSpec.M => M;

        NumericKind IMaskSpec.K 
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<T>();
        }

        uint IBitFrequency.F 
        {
            [MethodImpl(Inline)]
            get => (uint)TypeNats.value<F>();
        }

        uint IBitDensity.D 
        {
            [MethodImpl(Inline)]
            get => (uint)TypeNats.value<D>();
        }

        [MethodImpl(Inline)]
        public JsbMask<F,D,S> As<S>(S s = default)
            where S : unmanaged
                => default;

        public override string ToString()
            => (this as ITextual).Format();
    }
}