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
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static bit test<T>(T src, int pos)
            where T : unmanaged
                => BitMaskG.testbit(src, (byte)pos);

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static bit test<T>(T src, uint pos)
            where T : unmanaged
                => BitMaskG.testbit(src, (byte)pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bit test<T>(T src, byte pos)
            where T : unmanaged
                => BitMaskG.testbit(src, pos);
    }
}