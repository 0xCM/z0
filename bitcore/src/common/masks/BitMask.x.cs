//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    using static BitMasks;

    public static partial class BitMaskX
    {                

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