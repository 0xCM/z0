//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {

        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> valt<T>(N256 n, T a, T b)
            where T : unmanaged
        {            
            var x = vbroadcast(n,a);
            var y = vbroadcast(n,b);
            var m = DataPatterns.blendspec<T>(n,false);
            return vblend32x8(x,y,m);
        }


        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> valt<T>(N128 n, T a, T b)
            where T : unmanaged
        {            
            var data = BlockedSpan.alloc<T>(n);
            var len = BlockedSpan.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
                seek(ref mem, i) = even(i) ? a : b;
            return ginx.vload(n, in head(data));
        }
    }
}