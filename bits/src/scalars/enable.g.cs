//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, int pos)
            where T : unmanaged
                => ref BitMaskG.enable(ref src, pos);

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static T enable<T>(T src, int pos)
            where T : unmanaged
                => BitMaskG.enable(ref src, pos);
    }
}