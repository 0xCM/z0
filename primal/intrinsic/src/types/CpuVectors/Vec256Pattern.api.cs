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

    /// <summary>
    /// Defines an api for accessing/specifying 256-bit pattern vectors
    /// </summary>
    public static class Vec256Pattern
    {        
        /// <summary>
        /// Returns an immutable reference to a vector where each component is assigned the numeric value 1
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static ref readonly Vec256<T> Units<T>()
            where T : unmanaged
                => ref Vec256Pattern<T>.Units;

        /// <summary>
        /// Returns a vector with all bits turned on
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static  Vec256<T> ones<T>()
            where T : unmanaged        
                => ginx.vones256<T>();

        /// <summary>
        /// Returns a vector with all bits turned off
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static  Vec256<T> zeroes<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        static Vec256<T> LoadPattern<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => dinx.vloadu256(in src[0]).As<T>();

        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> LaneMerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return LoadPattern<T>(Vec256PatternData.LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return LoadPattern<T>(Vec256PatternData.LaneMerge256x16u);
            else 
                return Vec256<T>.Zero;            
        }
                
        /// <summary>
        /// For a vector of length N, returns a reference to the vector [0, 1, ..., N - 1]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Increasing<T>()
            where T : unmanaged
                => Vec256Pattern<T>.Increasing;

        /// <summary>
        /// For a vector of length N, returns a reference to the vector [N - 1, N - 2, , ..., 0]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static ref readonly Vec256<T> Decreasing<T>()
            where T : unmanaged
                => ref Vec256Pattern<T>.Decreasing;

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
        /// Defines a vector of 32 or 64-bit floating point values where each component 
        /// has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        public static ref readonly Vec256<T> FpSignMask<T>()
            where T : unmanaged
                => ref Vec256Pattern<T>.FpSignMask;

        /// <summary>
        /// Creates a vector with incrementing components, v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Increments<T>(T first = default)
            where T : unmanaged  
                => Vec256Pattern<T>.Increments(first);

        /// <summary>
        /// Creates a vector with decrementing components v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec256<T> Decrements<T>(T last = default)
            where T : unmanaged  
                => Vec256Pattern<T>.Decrements(last);

        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Alternate<T>(T a, T b)
            where T : unmanaged
        {            
            var n = Vec256<T>.Length;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
                dst[i] = even(i) ? a : b;
            return Vec256.Load(ref head(dst));
        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Increasing<T>(T start, T step)
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
            return Vec256.Load(ref head(dst));

        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Decreasing<T>(T start, T step)
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
            return Vec256.Load(ref head(dst));

        }


    }
}