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
    /// Defines a specification for producing classified bitmasks
    /// </summary>
    public readonly struct MaskSpec : IMaskSpec
    {
        [MethodImpl(Inline)]
        public static MaskSpec Define(MaskKind m, NumericKind k, uint f, uint d)
            => new MaskSpec(m,k,f,d);

        [MethodImpl(Inline)]
        public static MaskSpec Define<F,D,T>(MaskKind m, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => new MaskSpec(m, NumericKinds.kind<T>(), (uint)TypeNats.value<F>(), (uint)TypeNats.value<D>());

        [MethodImpl(Inline)]
        MaskSpec(MaskKind m, NumericKind k, uint f, uint d)
        {
            M = m;
            K = k;
            F = f;
            D = d;
        }

        public MaskKind M {get;}

        public uint F {get;}

        public uint D {get;}

        public NumericKind K {get;}

        public string Format()
            => K.Format();
    }
}