//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial struct BitSpan
    {

        /// <summary>
        /// Creates a bitspan from a parameter array
        /// </summary>
        /// <param name="src">The sorce bits</param>
        [MethodImpl(Inline)]
        public static BitSpan parts(params bit[] src)
            => new BitSpan(src);
 
    }

}