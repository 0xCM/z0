//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Konst;        

    using K = Kinds;

    partial class Blocks
    {

        /// <summary>
        /// Allocates a single 256-bit block over cells of parametric kind
        /// </summary>
        /// <param name="w">The block width</param>
        /// <param name="nk">The numeric kind</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Alloc, Closures(AllNumeric)]
        public static Block256<T> alloc<T>(BlockedKind<W256,T> k, int count)
            where T : unmanaged        
                => alloc<T>(k.Width, 1);
    }
}