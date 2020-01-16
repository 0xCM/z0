//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    partial class dinx
    {                
        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vrotrv(Vector128<uint> src, Vector128<uint> counts)
            => dinx.vor(dinx.vsrlv(src, counts),dinx.vsllv(src, dinx.vsub(Vector128u32, counts)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vrotrv(Vector128<ulong> src, Vector128<ulong> counts)
            => dinx.vor(dinx.vsrlv(src, counts),dinx.vsllv(src, dinx.vsub(Vector128u64, counts)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vrotrv(Vector256<uint> src, Vector256<uint> counts)
            => dinx.vor(dinx.vsrlv(src, counts),dinx.vsllv(src, dinx.vsub(Vector256u32, counts)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The variable shift spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vrotrv(Vector256<ulong> src, Vector256<ulong> counts)
            => dinx.vor(dinx.vsrlv(src, counts),dinx.vsllv(src, dinx.vsub(Vector256u64, counts)));             
    }
}