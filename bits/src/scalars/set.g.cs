//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T set<T>(ref T src, byte pos, bit value)            
            where T : unmanaged
                => ref BitMaskG.set(ref src, pos, value);


    }
}