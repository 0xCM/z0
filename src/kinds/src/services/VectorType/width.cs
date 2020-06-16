//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    using TW = TypeWidth;
    using VW = VectorWidth;

    partial class VectorType
    {
        [MethodImpl(Inline)]
        public static VW vwidth<W>(W w = default)
            where W : struct, IVectorWidth
        {            
            if(typeof(W) == typeof(W128))
                return VW.W128;
            else if(typeof(W) == typeof(W256))
                return VW.W256;
            else if(typeof(W) == typeof(W512))
                return VW.W512;
            else
                return VW.None;
        }

        [MethodImpl(Inline), Op]
        public static TW width(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType 
                    ? eff.GetGenericTypeDefinition() 
                    : (eff.IsGenericTypeDefinition ? eff : null);

            if(def != null)            
            {
                if(def == typeof(Vector128<>))            
                    return TW.W128;
                else if(def == typeof(Vector256<>))
                    return TW.W256;
                else if(def == typeof(Vector512<>))
                    return TW.W512;
            }            
            
            return TW.None;
        }
    }
}