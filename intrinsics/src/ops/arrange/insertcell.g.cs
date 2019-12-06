//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Inserts a cell into the target at an index-identified location
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="index">The 0-based component index</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vinsertcell<T>(T src, int index, Vector128<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);

        /// <summary>
        /// Inserts a cell into the target at an index-identified location
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="index">The 0-based component index</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vinsertcell<T>(T src, int index, Vector256<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);
    }
}