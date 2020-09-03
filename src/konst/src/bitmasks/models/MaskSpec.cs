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
    /// Defines a specification for producing classified bitmasks
    /// </summary>
    public readonly struct MaskSpec : IMaskSpec
    {
        [MethodImpl(Inline)]
        public static MaskSpec define<F,D,T>(BitMaskKind m, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => new MaskSpec(m, NumericKinds.kind<T>(), (uint)TypeNats.value<F>(), (uint)TypeNats.value<D>());

        [MethodImpl(Inline)]
        public MaskSpec(BitMaskKind m, NumericKind k, uint f, uint d)
        {
            M = m;
            K = k;
            F = f;
            D = d;
        }

        public BitMaskKind M {get;}

        public uint F {get;}

        public uint D {get;}

        public NumericKind K {get;}

        public string Format()
            => K.Format();
    }
}