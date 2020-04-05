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
   
    using static Core;

    partial class VCore
    {
        /// <summary>
        /// Extracts the first T-indexed component after converting the S-vector to a T-vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T vfirst<S,T>(Vector128<S> src)
            where S : unmanaged
            where T : unmanaged
                => vcell<S,T>(src,0);

    }
}