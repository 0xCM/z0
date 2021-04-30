//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class TypeNats
    {
        // /// <summary>
        // /// Constructs an natural dimension of order 2
        // /// </summary>
        // /// <typeparam name="M">The type of the first axis</typeparam>
        // /// <typeparam name="N">The type of the second axis</typeparam>
        // [MethodImpl(Inline)]
        // public static Dim<M,N> dim<M,N>(M m = default, N n = default)
        //     where M : unmanaged, ITypeNat
        //     where N : unmanaged, ITypeNat
        //         => default;

        /// <summary>
        /// Constructs the canonical sequence representatives for the natural numbers within an inclusive range
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public static IEnumerable<INatSeq> between(ulong min, ulong max)
        {
            for(var i = min; i<= max; i++)
                yield return reflect(i);
        }
   }
}