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
        /// Returns a 128-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vones<T>(N128 n)
            where T : unmanaged
                => ginx.veq(default(Vector128<T>), default(Vector128<T>));

        /// <summary>
        /// Returns a 256-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vones<T>(N256 n)
            where T : unmanaged
                => ginx.veq(default(Vector256<T>), default(Vector256<T>));

        /// <summary>
        /// Returns a 128-bit vector where each component is assigned the value 1
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(N128 n)
            where T : unmanaged
                => DataPatterns.uints<T>(n);

        /// <summary>
        /// Returns a 256-bit vector where each component is assigned the value 1
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(N256 n)
            where T : unmanaged
                => DataPatterns.uints<T>(n);

        /// <summary>
        /// Describes a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> valtclear<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(ClearAlt256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(ClearAlt256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vlanemerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return load<T>(LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return load<T>(LaneMerge256x16u);
            else 
                return default;
        }

        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> fpsign<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return As.generic<T>(dfp.vbroadcast(n256,-0.0f));
            else if(typeof(T) == typeof(double))
                return As.generic<T>(dfp.vbroadcast(n256,-0.0));
            else 
                return default;
        }

        [MethodImpl(Inline)]
        static Vector256<T> load<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
        {
            dinx.vload(in head(src), out Vector256<byte> dst);
            return As.generic<T>(dst);
        }

        static ReadOnlySpan<byte> LaneMerge256x8u 
            => new byte[32]{0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31};
        
        static ReadOnlySpan<byte> LaneMerge256x16u 
            => new byte[32]{0x00,0x00,0x02,0x00,0x04,0x00,0x06,0x00,0x08,0x00,0x0A,0x00,0x0C,0x00,0x0E,0x00,0x01,0x00,0x03,0x00,0x05,0x00,0x07,0x00,0x09,0x00,0x0B,0x00,0x0D,0x00,0x0F,0x00 };
        
        static ReadOnlySpan<byte> ClearAlt256x8u 
            => new byte[32]{0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff,0x00,0xff,0x02,0xff,0x04,0xff,0x06,0xff,0x08,0xff,0x0a,0xff,0x0c,0xff,0x0e,0xff};        
        
        static ReadOnlySpan<byte> ClearAlt256x16u 
            => new byte[32]{0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff,0x00,0x00,0xff,0xff,0x02,0x00,0xff,0xff,0x04,0x00,0xff,0xff,0x06,0x00,0xff,0xff};
    }
}