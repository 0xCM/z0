//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static partial class Classifiers{}

    public static partial class Classified
    {
        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool segmented(Type t)
            => BlockedType.test(t) || VectorType.test(t);

        public static FixedWidth width(Type t)
        {
            if(PrimalType.test(t))
                return (FixedWidth)PrimalType.width(t);
            else if(VectorType.test(t))
                return (FixedWidth)VectorType.width(t);
            else if(BlockedType.test(t))
                return (FixedWidth)BlockedType.width(t);
            else
                return FixedWidth.None;
        }

        [MethodImpl(Inline)]
        public static int size(Type t)
            => (int)width(t)/8;

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> segtype(Type t)
            => segmented(t) ? t.GenericTypeArguments[0] : default;        
    }
}