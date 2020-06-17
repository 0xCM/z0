//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NBK = NumericBaseKind;
    using NBI = NumericBaseIndicator;

    partial class NumericBases
    {
        [MethodImpl(Inline)]
        public static NBK kind<B>(B b = default)
            where B : unmanaged, INumericBase
        {
            if(typeof(B) == typeof(Base2))
                return NBK.Base2;
            else if(typeof(B) == typeof(Base3))
                return NBK.Base3;
            else if(typeof(B) == typeof(Base8))
                return NBK.Base8;
            else if(typeof(B) == typeof(Base10))
                return NBK.Base10;
            else if(typeof(B) == typeof(Base16))
                return NBK.Base16;
            else
                return NBK.None;            
        }

        [MethodImpl(Inline), Op]
        public static NBK kind(NBI src)
        {
            if(src == NBI.Base2)
                return NBK.Base2;
            else if(src == NBI.Base16)
                return NBK.Base16;
            else if(src == NBI.Base10)
                return NBK.Base10;
            else if(src == NBI.Base8)
                return NBK.Base8;
            else if(src == NBI.Base3)
                return NBK.Base3;
            else
                return NBK.None;
        }    
    }
}