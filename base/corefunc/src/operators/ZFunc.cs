//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class ZFunc
    {
        /// <summary>
        /// Derives a method signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        public static MethodSig signature(MethodInfo src)
            => MethodSig.Define(src);

        /// <summary>
        /// Produces an operation signature from reflected method metadata and supplied type argments, if applicable
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The arguments over which to close the method, if generic</param>
        public static OpDescriptor descriptor(MethodInfo m, params Type[] args)
            => OpDescriptor.Define(m,args);

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool intrinsic(Type t, int? width)        
        {
            if(t.IsGenericType && width != null)
            {
                var def = t.GetGenericTypeDefinition();
                if(def == typeof(Vector64<>) && width == 64)
                    return true;
                else if(def == typeof(Vector128<>) && width == 128)
                    return true;
                else if (def == typeof(Vector256<>) && width == 256)
                    return true;
                else if (def == typeof(Vector512<>) && width == 512)
                    return true;
                else if (def == typeof(Vector1024<>) && width == 1024)
                    return true;
                else
                    return false;
            }
            else
                return t.IsIntrinsic();
        }

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool intrinsic(Type t)
        {
            if(t.IsGenericType)
            {
                var def = t.GetGenericTypeDefinition();
                if(
                    def == typeof(Vector64<>)
                 || def == typeof(Vector128<>) 
                 || def == typeof(Vector256<>) 
                 || def == typeof(Vector1024<>) 
                 || def == typeof(Vector512<>)
                 )
                    return true;
            }
            return false;
        }

        /// <summary>
        /// If the source type is primal or intrinsic, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int bitwidth(Type t)
        {
            if(t.IsGenericType)
            {
                var def = t.GetGenericTypeDefinition();

                if(def == typeof(Vector64<>))
                    return 64;
                else if(def == typeof(Vector128<>))
                    return 128;
                else if (def == typeof(Vector256<>))
                    return 256;
                else if (def == typeof(Vector512<>))
                    return 512;
                else if (def == typeof(Vector1024<>))
                    return 1024;
                else
                    return 0;
            }
            else
                return t.PrimalBitWidth();
        }

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool vectorized(MethodInfo m, bool total = false)        
            => total ? (intrinsic(m.ReturnType) && m.ParameterTypes().All(intrinsic)) 
                     : (intrinsic(m.ReturnType) || m.ParameterTypes().Any(intrinsic));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool vectorized(MethodInfo m, int? width, bool total)        
            => total ? (intrinsic(m.ReturnType,width) && m.ParameterTypes().All(t => intrinsic(t,width))) 
                     : (intrinsic(m.ReturnType,width) || m.ParameterTypes().Any(t => intrinsic(t,width)));

        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int>[] inputwidths(MethodInfo m)
            => m.GetParameters().Select(p => paired(p, bitwidth(p.ParameterType))).ToArray();

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> outputwidth(MethodInfo m)
            => paired(m.ReturnParameter, m.ReturnType.BitWidth());

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool segmented(Type t)
            => t.IsDataBlock() || intrinsic(t);

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> segtype(Type t)
            => segmented(t) ? t.GenericTypeArguments[0] : default;        
    }
}