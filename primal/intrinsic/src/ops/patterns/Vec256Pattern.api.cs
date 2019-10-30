//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    /// <summary>
    /// Defines an api for accessing/specifying 256-bit pattern vectors
    /// </summary>
    public static class Vec256Pattern
    {        
        /// <summary>
        /// Returns an immutable reference to a vector where each component is assigned the numeric value 1
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        internal static Vector256<T> units<T>()
            where T : unmanaged
        {            
            var n = n256;
            var data = BlockedSpan.AllocBlock(n, gmath.one<T>());
            return ginx.vload(n, in data.Head);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> ones<T>()
            where T : unmanaged
                => ginx.veq(default(Vector256<T>), default(Vector256<T>));

        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        internal static Vector256<T> LaneMerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(Vec256PatternData.LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(Vec256PatternData.LaneMerge256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Creates a vector with incrementing components v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged
        {
            var n = Vector256<T>.Count;
            var src = Span256.Load(range(first, gmath.add(first, convert<T>(n - 1))).ToArray().AsSpan());
            return src.Swap(swaps).LoadVector();
        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> increments<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vector256<T>.Count;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.add(ref current, step);
            }
            return ginx.vload(n256, in head(dst));
        }

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [N - 1, N - 2, , ..., 0]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> decrements<T>(T last = default, params Swap[] swaps)
            where T : unmanaged
        {
            var n = Vector256<T>.Count;
            var dst = Span256.Alloc<T>(n);
            var val = last;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return dst.Swap(swaps).LoadVector();
        }            

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> decrements<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vector256<T>.Count;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.sub(ref current, step);
            }
            return ginx.vload(n256, in head(dst));
        }

        /// <summary>
        /// Describes a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> altclear<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(Vec256PatternData.ClearAlt256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(Vec256PatternData.ClearAlt256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        public static Vector256<T> fpsign<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return As.generic<T>(dfp.vbroadcast(n256,-0.0f));
            else if(typeof(T) == typeof(double))
                return As.generic<T>(dfp.vbroadcast(n256,-0.0));
            else 
                return default;
        }

        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> alternating<T>(T a, T b)
            where T : unmanaged
        {            
            var n = Vec256<T>.Length;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
                dst[i] = even(i) ? a : b;
            return ginx.vload(n256, in head(dst));
        }

        [MethodImpl(Inline)]
        static Vector256<T> load<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
        {
            dinx.vload(in head(src), out Vector256<byte> dst);
            return As.generic<T>(dst);
        }
    }
}