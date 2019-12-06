//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class gcells
    {
        /// <summary>
        /// Rotates source cells leftward and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The leading source cell</param>
        /// <param name="shift">The amount to rotate</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static void rotl<T>(in T src, int shift, ref T dst, int count)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)   
               seek(ref dst, i) =  gbits.rotl(skip(in src, i),shift);
        }

        /// <summary>
        /// Rotates source cells rightward and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The leading source cell</param>
        /// <param name="shift">The amount to rotate</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static void rotr<T>(in T src, int shift, ref T dst, int count)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)   
               seek(ref dst, i) =  gbits.rotr(skip(in src, i),shift);
        }

    }

}