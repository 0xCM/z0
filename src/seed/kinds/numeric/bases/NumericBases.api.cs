//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class NumericBases
    {
        public static Base2 B => default;

        public static Base3 T => default;

        public static Base8 O => default;

        public static Base10 D => default;

        public static Base16 X => default;

        [MethodImpl(Inline)]
        public static NumericBaseKind kind<B>(B b = default)
            where B : unmanaged, INumericBase
        {
            if(typeof(B) == typeof(Base2))
                return NumericBaseKind.B;
            else if(typeof(B) == typeof(Base3))
                return NumericBaseKind.T;
            else if(typeof(B) == typeof(Base8))
                return NumericBaseKind.O;
            else if(typeof(B) == typeof(Base10))
                return NumericBaseKind.D;
            else if(typeof(B) == typeof(Base16))
                return NumericBaseKind.X;
            else
                return NumericBaseKind.None;            
        }
    }
}