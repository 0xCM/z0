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

    public delegate Vec256<T> Perm64x4<T>(Vec256<T> src)
        where T : unmanaged;

    partial class ginxx
    {

        /// <summary>
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Replicate<T>(this Vec128<T> src)
            where T : unmanaged
                => Vec128.Load(src.ToSpan128());

        /// <summary>
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Replicate<T>(this Vec256<T> src)
            where T : unmanaged
                => Vec256.Load(src.ToSpan256());    

        [MethodImpl(Inline)]
        public static string Format(this Blend32x4 src)                
            => BitString.FromScalar((byte)src).Format(true);
    }
}