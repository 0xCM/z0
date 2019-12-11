//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Linear
    {
        [MethodImpl(Inline)]
        public static ref Covector<N,T> negate<N,T>(ref Covector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.negate(src.Span);
            return ref src;
        }

        /// <summary>
        /// Computes x[i] := x[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<T> mul<T>(ref VBlock256<T> x, in VBlock256<T> rhs)
            where T : unmanaged
        {
            mathspan.mul(x.Unblocked, rhs.Unblocked);
            return ref x;
        }

        /// <summary>
        /// Computes x[i] := x[i] * rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> mul<N,T>(ref VBlock256<N,T> x, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.mul(x.Unsized, rhs.Unsized);
            return ref x;
        }

        /// <summary>
        /// Computes x[i] := pow(x[i],rhs)  for i = 0...N-1
        /// </summary>
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> pow<N,T>(ref VBlock256<N,T> x, uint rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            mathspan.pow(x.Unsized, rhs);
            return ref x;
        }

        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<T> inc<T>(ref VBlock256<T> src)
            where T : unmanaged
        {
            mathspan.inc(src.Unblocked);
            return ref src;
        }
        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> inc<N,T>(ref VBlock256<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.inc(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<T> dec<T>(ref VBlock256<T> src)
            where T : unmanaged
        {
            mathspan.dec(src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Decrements each source vector component in-place: io[i] := --io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> dec<N,T>(ref VBlock256<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            mathspan.dec(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static VBlock256<P,T> concat<M,N,P,T>(in VBlock256<M,T> head, VBlock256<N,T> tail, P sum = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, INatSum<M,N>
            where T : unmanaged
        {
            var dst = span<T>(new NatSum<M,N>());
            head.Unsized.CopyTo(dst);
            tail.Unsized.CopyTo(dst.Slice((int)new M().NatValue));
            return VBlock256<P,T>.Load(dst);
        }
    }
}