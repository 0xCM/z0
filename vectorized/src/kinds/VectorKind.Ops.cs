//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    using static Root;
    using static NumericReps;

    public static partial class ReflectedVectorTypes
    {


    }

    /// <summary>
    /// Defines operations over the vector kind classifier
    /// </summary>
    public static class VectorKindOps
    {
        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W8 w)
            => k.HasCellType(z8) || k.HasCellType(z8i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W16 w)
            => k.HasCellType(z16) || k.HasCellType(z16i);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W32 w)
            => k.HasCellType(z32) || k.HasCellType(z32i) || k.HasCellType(z32f);

        /// <summary>
        /// Determines whether a vector of specified kind has a specified natural width
        /// </summary>
        /// <param name="k">The vector kind</param>
        /// <param name="w">The width to match</param>
        [MethodImpl(Inline)]
        public static bool HasCellWidth(this VectorKind k, W64 w)
            => k.HasCellType(z64) || k.HasCellType(z64i) || k.HasCellType(z64f);


        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => VectorType.width(k);
 
        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec128Kind hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec256Kind hk, bool total)        
            => m.IsVectorized(256, total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec128Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec256Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));
    }
}