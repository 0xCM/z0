//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    public static partial class TypeNats
    {        
        /// <summary>
        /// Consructs the canonical sequence representatives for the natural numbers within an inclusive range
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public static IEnumerable<NatSeq> between(ulong min, ulong max)
        {
            for(var i = min; i<= max; i++)
                yield return reflect(i);
        }
   }
}