//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;

    /// <summary>
    /// Defines a specification for producing Central-oriented masks
    /// </summary>
    /// <typeparam name="F">The repetition frequency type</typeparam>
    /// <typeparam name="D">The bit density type</typeparam>
    /// <typeparam name="T">The mask data type</typeparam>
    public readonly struct CentralMask<F,D,T> : IMaskSpec<F,D,T>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        public const MaskKind M = MaskKind.Central;

        public F f => default;

        public D d => default;

        public T t => default;

        [MethodImpl(Inline)]
        public static implicit operator MaskSpec(CentralMask<F,D,T> src)
            => MaskSpec.Define<F,D,T>(M);

        MaskKind IMaskSpec.M => M;
        
        NumericKind IMaskSpec.K 
        {
            [MethodImpl(Inline)]
            get => PrimalType.kind<T>();
        }

        uint IBitFrequency.F 
        {
            [MethodImpl(Inline)]
            get => (uint)nateval<F>();
        }

        uint IBitDensity.D 
        {
            [MethodImpl(Inline)]
            get => (uint)nateval<D>();
        }

        [MethodImpl(Inline)]
        public CentralMask<F,D,S> As<S>(S s = default)
            where S : unmanaged
                => default;

        public string Format()
            => $"central(f:{nateval<F>()}, d:{nateval<D>()}, t:{primalsig<T>()})";

        public override string ToString()
            => Format();
    }

}