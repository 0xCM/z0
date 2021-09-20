//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class math
    {
        /// <summary>
        /// Saturates a 16-bit signed integer to an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The saturation width width</param>
        [MethodImpl(Inline), Op]
        public static sbyte sat(short src, W8 dst)
        {
            if(src > sbyte.MaxValue)
                return sbyte.MaxValue;
            else if(src < sbyte.MinValue)
                return sbyte.MinValue;
            else
                return (sbyte)src;
        }

        /// <summary>
        /// Saturates a 32-bit signed integer to a 16-bit nsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The saturation width width</param>
        [MethodImpl(Inline), Op]
        public static short sat(int src, W16 dst)
        {
            if(src > short.MaxValue)
                return short.MaxValue;
            else if(src < short.MinValue)
                return short.MinValue;
            else
                return (short)src;
        }


        /// <summary>
        /// Saturates a 32-bit signed integer to a 16-bit nsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static short sat16(int src)
            => sat(src, w16);

        /// <summary>
        /// Saturates a 16-bit signed integer to an 8-bit signed integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static sbyte sat8(short src)
            => sat(src, w8);
    }
}