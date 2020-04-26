//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    using K = VectorWidth;

    partial class Widths
    {        
        [MethodImpl(Inline)]
        public static VectorWidth vector<W>(W w = default)
            where W : struct, IVectorWidth
        {            
            if(typeof(W) == typeof(W128))
                return K.W128;
            else if(typeof(W) == typeof(W256))
                return K.W256;
            else if(typeof(W) == typeof(W512))
                return K.W512;
            else
                return 0;
        }

        /// <summary>
        /// Determines the width of a system-defined or custom intrinsic vector type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static TypeWidth vector(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return TypeWidth.None;
            else if(def == typeof(Vector128<>))            
                return TypeWidth.W128;
            else if(def == typeof(Vector256<>))
                return TypeWidth.W256;
            else
                return t.Tag<VectorAttribute>().MapValueOrDefault(a => a.TypeWidth, TypeWidth.None);
        }
    }
}