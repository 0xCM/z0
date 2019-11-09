//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;
    using static AsIn;

    /// <summary>
    /// Defines generic bitmask functions that parameterize those defined in <see cref='BitMask'/>
    /// </summary>
    public static partial class BitMaskG
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
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
        }




    }
}