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
        public static NBI indicator<B>(B b = default)
            where B : unmanaged, INumericBase
        {
            if(typeof(B) == typeof(Base2))
                return NBI.Base2;
            else if(typeof(B) == typeof(Base3))
                return NBI.Base3;
            else if(typeof(B) == typeof(Base8))
                return NBI.Base8;
            else if(typeof(B) == typeof(Base10))
                return NBI.Base10;
            else if(typeof(B) == typeof(Base16))
                return NBI.Base16;
            else
                return NBI.None;            
        }

        [MethodImpl(Inline), Op]
        public static NBI indicator(NBK src)
        {
            if(src == NBK.Base2)
                return NBI.Base2;
            else if(src == NBK.Base16)
                return NBI.Base16;
            else if(src == NBK.Base10)
                return NBI.Base10;
            else if(src == NBK.Base8)
                return NBI.Base8;
            else if(src == NBK.Base3)
                return NBI.Base3;
            else
                return NBI.None;
        }    

        [MethodImpl(Inline), Op]
        public static NBI indicator(char src)
        {
            if(src == (char)NBI.Base2)
                return NBI.Base2;
            else if(src == (char)NBI.Base16)
                return NBI.Base16;
            else if(src == (char)NBI.Base10)
                return NBI.Base10;
            else if(src == (char)NBI.Base8)
                return NBI.Base8;
            else if(src == (char)NBI.Base3)
                return NBI.Base3;
            else
                return NBI.None;
        }
    }
}