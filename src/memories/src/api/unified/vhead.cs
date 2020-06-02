//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Extracts the first component of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T vhead<T>(Vector128<T> src)
            where T : unmanaged
                => vcell(src,0);

    }
}