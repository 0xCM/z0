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
    /// Defines a specification for producing classified bitmasks
    /// </summary>
    public readonly struct MaskSpec : IMaskSpec
    {
        [MethodImpl(Inline)]
        public static MaskSpec Define(MaskKind m, PrimalKind k, uint f, uint d)
            => new MaskSpec(m,k,f,d);

        [MethodImpl(Inline)]
        public static MaskSpec Define<F,D,T>(MaskKind m, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => new MaskSpec(m, PrimalType.kind<T>(), (uint)nateval<F>(),(uint)nateval<D>());

        [MethodImpl(Inline)]
        MaskSpec(MaskKind m, PrimalKind k, uint f, uint d)
        {
            M = m;
            K = k;
            F = f;
            D = d;
        }

        public MaskKind M {get;}

        public uint F {get;}

        public uint D {get;}

        public PrimalKind K {get;}

        public string Format()
            => primalsig(K);
    }
}