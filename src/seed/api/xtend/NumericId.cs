//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Determines the type identifer of a numeric kind
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline)]
        public static NumericTypeId NumericId(this NumericKind kind)
        {
            var noclass = ((uint)kind << 3) >> 3;
            var nowidth = (noclass >> 16) << 16;
            return (NumericTypeId)nowidth;            
        }
    }
}