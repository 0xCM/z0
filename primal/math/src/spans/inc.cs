//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        /// <summary>
        /// Increments each value in the source in-place
        /// </summary>
        /// <param name="src">The source values</param>
        public static Span<T> inc<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i = 0; i< src.Length; i++)
                gmath.inc(ref src[i]);
            return src;
        }
    }

}