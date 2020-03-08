//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    [ApiHost("api")]
    public static partial class BitVector
    {   
        /// <summary>
        /// Returns a generic vector with all bits enabled
        /// </summary>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> ones<T>()
            where T : unmanaged
                => Literals.ones<T>();           

        /// <summary>
        /// Returns a generic vector with all bits disabled
        /// </summary>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> zero<T>()
            where T : unmanaged
                => default;
    }
}