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
        public static Base2 Base2 => default;

        public static Base3 Base3 => default;

        public static Base8 Base8 => default;

        public static Base10 Base10 => default;

        public static Base16 Base16 => default;

        [MethodImpl(Inline)]
        public static NumericBaseKind kind<B>(B b = default)
            where B : unmanaged, INumericBase
        {
            if(typeof(B) == typeof(Base2))
                return NumericBaseKind.Base2;
            else if(typeof(B) == typeof(Base3))
                return NumericBaseKind.Base3;
            else if(typeof(B) == typeof(Base8))
                return NumericBaseKind.Base8;
            else if(typeof(B) == typeof(Base10))
                return NumericBaseKind.Base10;
            else if(typeof(B) == typeof(Base16))
                return NumericBaseKind.Base16;
            else
                return NumericBaseKind.None;            
        }
    }
}