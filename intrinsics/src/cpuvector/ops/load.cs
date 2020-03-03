//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static Root;
    
    partial class CpuVector
    {

        /// <summary>
        /// Loads a 512-bit vector from a readonly memory reference
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static unsafe Vector512<T> vload<T>(N512 w, in T src)
            where T : unmanaged
                => Vectors.vload(w,src);        


    }
}