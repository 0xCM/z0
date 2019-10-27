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
        public static Vector128<byte> reverse(Vector128<byte> src)
            => vshuffle(src, Vec128Pattern.Decrements<byte>(15));

        /// <summary>
        /// Reverses the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> reverse(Vector128<sbyte> src)
            => vshuffle(src, Vec128Pattern.Decrements<sbyte>(15));

        /// <summary>
        /// Reverses the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> reverse(Vector128<int> src)
            => vshuffle(src, Perm4.DCBA);

        /// <summary>
        /// Reverses the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> reverse(Vector128<uint> src)
            => vshuffle(src, Perm4.DCBA);

        [MethodImpl(Inline)]
        public static Vector256<byte> reverse(Vector256<byte> src)
            => vpermvar32x8(src, Vec256Pattern.Decrements<byte>(31));

        [MethodImpl(Inline)]
        public static Vector256<int> reverse(Vector256<int> src)
            => vpermvar8x32(src,MRev256i32);

        [MethodImpl(Inline)]
        public static Vector256<uint> reverse(Vector256<uint> src)
            => vpermvar8x32(src,MRev256u32);

        [MethodImpl(Inline)]
        public static Vector256<float> reverse(Vector256<float> src)
            => vpermvar8x32(src,MRev256f32);    
 
        static Vector256<int> MRev256i32 
            => cpuvec(7, 5, 6, 4, 3, 2, 1, 0);
        
        static Vector256<uint> MRev256u32 
            => cpuvec(7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);
        
        static Vector256<int> MRev256f32 
            => cpuvec(7, 6, 5, 4, 3, 2, 1, 0);    

    }
}