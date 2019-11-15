//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Reverses the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vreverse(Vector128<byte> src)
            => vshuf16x8(src, DataPatterns.decrements<byte>(n128));

        [MethodImpl(Inline)]
        public static Vector128<short> vreverse(Vector128<short> src)
            => vswaphl(vshuf4x16(src, Arrange4.DCBA, Arrange4.DCBA));

        [MethodImpl(Inline)]
        public static Vector128<ushort> vreverse(Vector128<ushort> src)
            => vswaphl(vshuf4x16(src, Arrange4.DCBA, Arrange4.DCBA));

        [MethodImpl(Inline)]
        public static Vector128<int> vreverse(Vector128<int> src)
            => vperm4x32(src, Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vector128<uint> vreverse(Vector128<uint> src)
            => vperm4x32(src, Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vector128<long> vreverse(Vector128<long> src)
            => vinsert(vsxcalar(src,0), vscalar(vsxcalar(src,1)), 1);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vreverse(Vector128<ulong> src)
            => vinsert(vxscalar(src,0), vscalar(vxscalar(src,1)), 1);

        [MethodImpl(Inline)]
        public static Vector256<byte> vreverse(Vector256<byte> src)
            => vinsert(vreverse(vhi(src)), vreverse(vlo(src)), out var _);

        [MethodImpl(Inline)]
        public static Vector256<uint> vreverse(Vector256<uint> src)
            => vperm8x32(src,MRev256u32);

        static Vector256<uint> MRev256u32 
            => vparts(n256, 7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);
        
    }
}