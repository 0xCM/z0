//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Components;

    public static class VectorTypes
    {
        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return false;

            return def == typeof(Vector128<>) || def == typeof(Vector256<>) || VectorAttribute.Test(def);             
        }

        [MethodImpl(Inline)]
        public static FixedWidth width(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return FixedWidth.None;
            else if(def == typeof(Vector128<>))            
                return FixedWidth.W128;
            else if(def == typeof(Vector256<>))
                return FixedWidth.W256;
            else
            {
                var tag = t.GetCustomAttribute<VectorAttribute>();
                if(tag != null)
                    return tag.TotalWdth;
                else
                    return FixedWidth.None;
            }                                         
        }
    }
}