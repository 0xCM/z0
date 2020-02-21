//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Text;

    using static zfunc;

    public static class SegmentX
    {
        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => t.IsBlocked() || t.IsVector();

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
        {
            if(VectorType.test(t))
                return VectorType.width(t);
            else if(t.IsBlocked())
                return BK.width(t);
            if(t.IsNumeric())
                return Numeric.width(t);
            else if(t == typeof(bit))
                return FixedWidth.W1;
            else
                return FixedWidth.None;
        }

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type SegmentType(this Type t)
            => t.IsSegmented() && t.IsClosedGeneric() ? t.SuppliedTypeArgs().Single() : typeof(void);        


    }
}