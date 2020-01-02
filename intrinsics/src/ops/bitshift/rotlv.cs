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
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The variable shift spec</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotlv(Vector128<uint> src, Vector128<uint> shift)
            => dinx.vor(dinx.vsllv(src, shift),dinx.vsrlv(src, dinx.vsub(Vector128u32, shift)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The variable shift spec</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotlv(Vector128<ulong> src, Vector128<ulong> shift)
            => dinx.vor(dinx.vsllv(src,shift),dinx.vsrlv(src, dinx.vsub(Vector128u64,shift)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The variable shift spec</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotlv(Vector256<uint> src, Vector256<uint> shift)
            => dinx.vor(dinx.vsllv(src,shift), dinx.vsrlv(src, dinx.vsub(Vector256u32,shift)));

        /// <summary>
        /// Rotates each component the source vector leftwards by the corresponding component in the shift spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The variable shift spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotlv(Vector256<ulong> src, Vector256<ulong> shift)
            => dinx.vor(dinx.vsllv(src,shift),dinx.vsrlv(src, dinx.vsub(Vector256u64,shift)));
    }

}