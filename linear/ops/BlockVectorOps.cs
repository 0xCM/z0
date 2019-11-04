//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {

        [MethodImpl(Inline)]
        public static BlockVector<N,T> xor<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            inxspan.xor(x.Data,y.Data,dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sll<N,T>(BlockVector<N,T> src, byte offset, BlockVector<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            inxspan.sll(src.Data, offset, dst.Data);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> sll<N,T>(BlockVector<N,T> src, byte offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            sll(src, offset, dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> srl<N,T>(BlockVector<N,T> src, byte offset, ref BlockVector<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            inxspan.srl(src.Data,offset,dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<N,T> srl<N,T>(BlockVector<N,T> src, byte offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = src.Replicate(true);
            return srl(src,offset,ref dst);
        }




        [MethodImpl(Inline)]
        public static ref Covector<N,T> ipow<N,T>(ref Covector<N,T> x, in Covector<N,uint> exp)
            where N : unmanaged, ITypeNat
            where T : unmanaged    

        {
            mathspan.pow(x.Span, exp.Span);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> ipow<N,T>(ref Covector<N,T> x, in uint exp)
            where N : unmanaged, ITypeNat
            where T : unmanaged    

        {
            mathspan.pow(x.Span, exp);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref Covector<N,T> flip<N,T>(ref Covector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    

        {
            mathspan.not(src.Span);
            return ref src;
        }


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
        public static ref BlockVector<T> mul<T>(ref BlockVector<T> x, in BlockVector<T> rhs)
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
        public static ref BlockVector<N,T> mul<N,T>(ref BlockVector<N,T> x, in BlockVector<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.mul(x.Unsized, rhs.Unsized);
            return ref x;
        }




        /// <summary>
        /// Computes x[i] := x[i] ^ rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> xor<N,T>(ref BlockVector<N,T> x, in BlockVector<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            mathspan.xor(x.Unsized, rhs.Unsized);
            return ref x;
        }

        /// <summary>
        /// Computes x[i] := x[i] ^ rhs for i = 0...N-1
        /// </summary>
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> xor<N,T>(ref BlockVector<N,T> x, in T rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            mathspan.xor(x.Unsized, rhs);
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
        public static ref BlockVector<N,T> pow<N,T>(ref BlockVector<N,T> x, uint rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            mathspan.pow(x.Unsized, rhs);
            return ref x;
        }

        /// <summary>
        /// Peforms a bitwise complement on each component in-place: io[i] := ~io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="x">The source/target operand will be updated in-place</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> flip<N,T>(ref BlockVector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    

        {
            mathspan.not(src.Unsized);
            return ref src;
        }

        /// <summary>
        /// Increments each source vector component in-place: io[i] := ++io[i]  for i = 0...N-1
        /// </summary>
        /// <param name="src">The source/target operand which will be updated in-place</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> inc<T>(ref BlockVector<T> src)
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
        public static ref BlockVector<N,T> inc<N,T>(ref BlockVector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.inc(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<T> dec<T>(ref BlockVector<T> src)
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
        public static ref BlockVector<N,T> dec<N,T>(ref BlockVector<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged    

        {
            mathspan.dec(src.Unsized);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static BlockVector<P,T> concat<M,N,P,T>(in BlockVector<M,T> head, BlockVector<N,T> tail, P sum = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, INatSum<M,N>
            where T : unmanaged
        {
            var dst = span<T>(new NatSum<M,N>());
            head.Unsized.CopyTo(dst);
            tail.Unsized.CopyTo(dst.Slice((int)new M().value));
            return BlockVector<P,T>.LoadAligned(dst);
        }
    }
}