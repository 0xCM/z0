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
        internal static Vector256<T> Units<T>()
            where T : unmanaged
        {            
            var n = n256;
            var data = BlockedSpan.AllocBlock(n, gmath.one<T>());
            return ginx.vloadu(n, in data.Head);
        }

        [MethodImpl(Inline)]
        static Vector256<T> LoadVector<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
        {
            dinx.vloadu(in head(src), out Vector256<byte> dst);
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> LoadPattern<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => dinx.vloadu256(in head(src)).As<T>();

        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        internal static Vector256<T> LaneMergeVector<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return LoadVector<T>(Vec256PatternData.LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return LoadVector<T>(Vec256PatternData.LaneMerge256x16u);
            else 
                return default;
        }

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [0, 1, ..., N - 1]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Increasing<T>()
            where T : unmanaged
                => Vec256Pattern<T>.Increasing;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [N - 1, N - 2, , ..., 0]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Decreasing<T>()
            where T : unmanaged
                => Vec256Pattern<T>.Decreasing;

        /// <summary>
        /// Describes a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ClearAlt<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return LoadPattern<T>(Vec256PatternData.ClearAlt256x8u);
            else if(typeof(T) == typeof(ushort))
                return LoadPattern<T>(Vec256PatternData.ClearAlt256x16u);
            else 
                return Vec256<T>.Zero;            
        }

        /// <summary>
        /// Describes a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> ClearAltVector<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return LoadVector<T>(Vec256PatternData.ClearAlt256x8u);
            else if(typeof(T) == typeof(ushort))
                return LoadVector<T>(Vec256PatternData.ClearAlt256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component 
        /// has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        public static Vector256<T> FpSignMask<T>()
            where T : unmanaged
                => Vec256Pattern<T>.FpSignMask;

        /// <summary>
        /// Creates a vector with incrementing components, v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> Increments<T>(T first = default)
            where T : unmanaged  
                => Vec256Pattern<T>.Increments(first);

        /// <summary>
        /// Creates a vector with decrementing components v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vector256<T> Decrements<T>(T last = default)
            where T : unmanaged  
                => Vec256Pattern<T>.Decrements(last);

        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> Alternate<T>(T a, T b)
            where T : unmanaged
        {            
            var n = Vec256<T>.Length;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
                dst[i] = even(i) ? a : b;
            return ginx.vloadu(n256, in head(dst));
        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> Increasing<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vec256<T>.Length;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.add(ref current, step);
            }
            return ginx.vloadu(n256, in head(dst));
        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> Decreasing<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vec256<T>.Length;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.sub(ref current, step);
            }
            return ginx.vloadu(n256, in head(dst));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> Ones<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vones_256u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vones_256i<T>();
            else 
                return vones_256f<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vones_256i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vones_256x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(vones_256x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(vones_256x32i());
            else 
                return generic<T>(vones_256x64i());
        }

        [MethodImpl(Inline)]
        static Vector256<T> vones_256u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vones_256x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vones_256x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(vones_256x32u());
            else 
                return generic<T>(vones_256x64u());
        }


        [MethodImpl(Inline)]
        static Vector256<T> vones_256f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(ones_256x32f());
            else if(typeof(T) == typeof(double))
                return generic<T>(ones_256x64f());
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Returns a 128x8u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<byte> vones_256x8u()
            => CompareEqual(default(Vector256<byte>), default(Vector256<byte>));

        /// <summary>
        /// Returns a 256x8i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<sbyte> vones_256x8i()
            => CompareEqual(default(Vector256<sbyte>), default(Vector256<sbyte>));

        /// <summary>
        /// Returns a 256x16i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<short> vones_256x16i()
            => CompareEqual(default(Vector256<short>), default(Vector256<short>));

        /// <summary>
        /// Returns a 256x16u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<ushort> vones_256x16u()
            => CompareEqual(default(Vector256<ushort>), default(Vector256<ushort>));

        /// <summary>
        /// Returns a 256x32i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<int> vones_256x32i()
            => CompareEqual(default(Vector256<int>), default(Vector256<int>));

        /// <summary>
        /// Returns a 256x32u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<uint> vones_256x32u()
            => CompareEqual(default(Vector256<uint>), default(Vector256<uint>));

        /// <summary>
        /// Returns a 256x64i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<long> vones_256x64i()
            => CompareEqual(default(Vector256<long>), default(Vector256<long>));

        /// <summary>
        /// Returns a 256x64u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vector256<ulong> vones_256x64u()
            => CompareEqual(default(Vector256<ulong>), default(Vector256<ulong>));

        /// <summary>
        /// Returns a 256x32f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vec256<float> ones_256x32f()
            => Compare(default(Vector256<float>), default(Vector256<float>), FloatComparisonMode.UnorderedEqualNonSignaling);

        /// <summary>
        /// Returns a 256x64f vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        static Vec256<double> ones_256x64f()
            => Compare(default(Vector256<double>), default(Vector256<double>), FloatComparisonMode.UnorderedEqualNonSignaling);

    }
}