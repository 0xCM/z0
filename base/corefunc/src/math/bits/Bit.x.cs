//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<Bit> ToBitStream<T>(this IEnumerator<T> src)
            where T : unmanaged
        {
            while(src.MoveNext())
            {
                var bs = BitString.FromScalar(src.Current);
                for(var i = 0; i< 64; i++)
                    yield return bs[i];                                    
            }
        }

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Bit> ToBitStream<T>(this IEnumerable<T> src)
            where T : unmanaged
                => src.GetEnumerator().ToBitStream();

    }
}