//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    
    partial class BitsX
    {    
        /// <summary>
        /// Retrieves, at most, one cell's worth of bits defined by an inclusive bit index range
        /// </summary>
        /// <param name="first">The linear index of the first bit</param>
        /// <param name="last">The linear index of the last bit</param>
        [MethodImpl(Inline)]
        public static T BitSeg<T>(this Span<T> src, int first, int last)
            where T : unmanaged
                => gbits.bitseg(src,first,last);

        /// <summary>
        /// Retrieves, at most, one cell's worth of bits defined by an inclusive bit index range
        /// </summary>
        /// <param name="first">The linear index of the first bit</param>
        /// <param name="last">The linear index of the last bit</param>
        [MethodImpl(Inline)]
        public static T BitSeg<T>(this Block256<T> src, int first, int last)
            where T : unmanaged
                => gbits.bitseg(src,first,last);


        /// <summary>
        /// Converts a bitview to a bitstring
        /// </summary>
        /// <param name="src">The view source</param>
        /// <typeparam name="T">The data type on which the view is predicated</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this BitView<T> src, int? maxbits = null)
            where T : unmanaged
                => src.Bytes.ToBitString(maxbits);
    }
}