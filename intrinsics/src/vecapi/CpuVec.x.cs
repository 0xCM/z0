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

    public static class CpuVecX
    {
        /// <summary>
        /// Extracts the value of an index-identified component from the source vector
        /// </summary>
        /// <param name="src">THe source vector</param>
        /// <param name="index">The component index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T Item<T>(this Vector128<T> src, int index)
            where T : unmanaged
                => CpuVec128.item(src,index);

        /// <summary>
        /// Extracts the value of an index-identified component from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The component index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T Item<T>(this Vector256<T> src, int index)
            where T : unmanaged
                => src.GetElement(index);

        /// <summary>
        /// Sets the value of an index-identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The component index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> Insert<T>(this Vector128<T> src, int index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        /// <summary>
        /// Sets the value of an index-identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The component index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Insert<T>(this Vector256<T> src, int index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        [MethodImpl(Inline)]
        public static string Format(this Blend4x32 src)                
            => BitString.from((byte)src).Format(true);

        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this Perm<N16> src)
        {
            var data = src.Terms.Convert<byte>();
            return ginx.vload(n128,in head(data));
        }

        [MethodImpl(Inline)]
        public static Perm<N16> ToPerm(this Vector128<byte> src)
        {
            Span<byte> dst = new byte[16];
            vstore(src, ref head(dst));
            return Perm.Define(n16, dst.Convert<int>());
        }

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> Next<T>(this Vector128<T> src)
            where T : unmanaged
                => ginx.vnext(src);

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Next<T>(this Vector256<T> src)
            where T : unmanaged
                => ginx.vnext(src);

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> Prior<T>(this Vector128<T> src)
            where T : unmanaged
                => ginx.vprior<T>(src);

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Prior<T>(this Vector256<T> src)
            where T : unmanaged
                => ginx.vprior<T>(src);
 
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this in ConstBlock256<T> src, int block = 0)            
            where T : unmanaged      
        {      
            ginx.vload(in src.SeekBlock(block), out Vector256<T> x);
            return x;
        }

        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this in ConstBlock128<T> src, int block = 0)            
            where T : unmanaged      
        {      
            ginx.vload(in src.SeekBlock(block), out Vector128<T> x);
            return x;
        }

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this Span<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => ginx.vload(n, in seek(src, offset));

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this Span<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => ginx.vload(n,in seek(src, offset));

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this ReadOnlySpan<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => ginx.vload(n,in skip(src, offset));

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this ReadOnlySpan<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => ginx.vload(n,in skip(src, offset));

        /// <summary>
        /// Loads a 128-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this in Block128<T> src, int block = 0)            
            where T : unmanaged            
                => ginx.vload(n128, in src.SeekBlock(block));

        /// <summary>
        /// Loads a 256-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this in Block256<T> src, int block = 0)            
            where T : unmanaged            
                => ginx.vload(n256, in src.SeekBlock(block));

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector128<T> src)
            where T : unmanaged            
                => vcount<T>(n128);

        [MethodImpl(Inline)]
        public static Span<T> Store<T>(this Vector128<T> src, Span<T> dst)
            where T : unmanaged            
        {
            vstore(src, ref head(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> Store<T>(this Vector256<T> src, Span<T> dst)
            where T : unmanaged            
        {
            vstore(src, ref head(dst));
            return dst;
        }

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector256<T> src)
            where T : unmanaged            
                => vcount<T>(n256);

        /// <summary>
        /// Loads a 256-bit cpu vector from a compatibly-blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> TakeVector<T>(this in Block256<T> src, int block = 0)
            where T : unmanaged
                => ginx.vload(n256, in src.SeekBlock(block));

        /// <summary>
        /// Loads a 128-bit cpu vector from a compatibly-blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> TakeVector<T>(this in Block128<T> src, int block = 0)
            where T : unmanaged
                => ginx.vload(n128, in src.SeekBlock(block));

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map<S,T>(this Vector128<S> lhs, Vector128<S> rhs, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n128), vcount<T>(n128));
            var dstLen = vcount<T>(n128);
            var lhsData = lhs.ToSpan();
            var rhsData = rhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return ginx.vload(n128, in head(dst));        
        } 

        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector128<T> Map<S,T>(this Vector128<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n128), vcount<T>(n128));
            var dstLen = vcount<T>(n128);
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);
            return ginx.vload(n128, in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 256-bit target vector via alternating application of a mapping function
        /// dst[j] = f(lhs[i])
        /// dst[j+1] = f(rhs[i])
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Merge<T>(this Vector128<T> x, Vector128<T> y, Func<T,T> f)
            where T : unmanaged
        {
            var srcLen = vcount<T>(n128);
            var dstLen = 2*srcLen;
            var lhsData = x.ToSpan();
            var rhsData = y.ToSpan();
            Span<T> dst = new T[dstLen];
            var j=0;
            for(var i=0; i< srcLen; i++)
            {
                dst[j++] = f(lhsData[i]);
                dst[j++] = f(rhsData[i]);
            }
            
            return ginx.vload(n256, in head(dst));        
        } 

        /// <summary>
        /// Projects a source vector into a target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map<S,T>(this Vector256<S> src, Func<S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var xLen = Math.Min(vcount<S>(n256), vcount<T>(n256));
            var dstLen = vcount<T>(n256);
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(data[i]);            
            return ginx.vload(n256, in head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vector256<T> Map<S,T>(this Vector256<S> x, Vector256<S> y, Func<S,S,T> f)
            where T : unmanaged
            where S : unmanaged
        {
            var n = n256;
            var xLen = Math.Min(vcount<S>(n), vcount<T>(n));
            var dstLen = vcount<T>(n);
            var lhsData = x.ToSpan();
            var rhsData = y.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhsData[i],rhsData[i]);
            return ginx.vload(n, in head(dst));        
        } 
    }
}