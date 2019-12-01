//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
       /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vcontract(Vector256<ulong> src, out Vector128<uint> dst)            
        {
            dst = default;
            dst = vcell(dst,0,(uint)vcell(src,0));
            dst = vcell(dst,1,(uint)vcell(src,1));
            dst = vcell(dst,2,(uint)vcell(src,2));
            dst = vcell(dst,3,(uint)vcell(src,3));
            return dst;
        }



        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static Vector128<int> vcontract(Vector256<long> src, out Vector128<int> dst)            
        {
            dst = default;
            dst = vcell(dst,0,(int)vcell(src,0));
            dst = vcell(dst,1,(int)vcell(src,1));
            dst = vcell(dst,2,(int)vcell(src,2));
            dst = vcell(dst,3,(int)vcell(src,3));
            return dst;
        }


    }

}