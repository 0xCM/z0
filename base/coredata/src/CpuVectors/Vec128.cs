//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static zfunc;    

    /// <summary>
    /// Represents a 128-bit cpu vector for use with intrinsic operations
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct Vec128<T> : IEquatable<Vec128<T>>
        where T : unmanaged
    {            
        /// <summary>
        /// The backing data
        /// </summary>
        public readonly Vector128<T> xmm;        

        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => new Vec128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => src.xmm;

        [MethodImpl(Inline)]
        public static bool operator ==(in Vec128<T> lhs, in Vec128<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in Vec128<T> lhs, in Vec128<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public Vec128(Vector128<T> src)
            => this.xmm = src;

        /// <summary>
        /// Presents the currect current vector[T] as vector[U] where U is a primal type. 
        /// Non-allocating
        /// </summary>
        /// <typeparam name="U">The target primal type</typeparam>
        [MethodImpl(Inline)]
        public Vec128<U> As<U>() 
            where U : unmanaged
                => Unsafe.As<Vector128<T>, Vec128<U>>(ref Unsafe.AsRef(in xmm));         

        [MethodImpl(Inline)]
        public bool Equals(Vec128<T> rhs)
             => xmm.Equals(rhs.xmm);

        public override string ToString()
            => xmm.ToString();

        public override int GetHashCode()
            => xmm.GetHashCode();

        public override bool Equals(object obj)
            => obj is Vec128<T> v ? Equals(v) : false;

    }     
}