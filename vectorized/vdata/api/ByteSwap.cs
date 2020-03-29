//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Core;
    using static HexConst;
 
    partial class Data
    {
        /// <summary>
        /// Retrieves the shuffle pattern that, when applied, swaps the byte-level representation 
        /// of each  unsigned 16,32, or 64-bit integer component value
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The integer width representative where n = 16 | 32 | 64</param>
        /// <typeparam name="N">The integer width type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<byte> byteswap<N>(N128 w, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N16))
                return vload<byte>(w, ByteSwap128x16u);
            else if(typeof(N) == typeof(N32))
                return vload<byte>(w, ByteSwap128x32u);
            else if(typeof(N) == typeof(N64))
                return vload<byte>(w, ByteSwap128x64u);
            else
                throw Unsupported.define<N>();            
        }

        /// <summary>
        /// Retrieves the shuffle pattern that, when applied, swaps the byte-level representation 
        /// of each  unsigned 16,32, or 64-bit integer component value
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The integer width representative where n = 16 | 32 | 64</param>
        /// <typeparam name="N">The integer width type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<byte> byteswap<N>(N256 w, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N16))
                return vload<byte>(w, ByteSwap256x16u);
            else if(typeof(N) == typeof(N32))
                return vload<byte>(w, ByteSwap256x32u);
            else if(typeof(N) == typeof(N64))
                return vload<byte>(w, ByteSwap256x64u);
            else
                throw Unsupported.define<N>();            
        }
         
        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x16u
            => new byte[16]{1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E};

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x32u
            => new byte[16]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap128x64u
            => new byte[16]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 16-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x16u
            => new byte[32]{
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E,
                1,0,3,2,5,4,7,6,9,8,B,A,D,C,F,E
                };

        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 32-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x32u
            => new byte[32]{
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C,
                3,2,1,0,7,6,5,4,B,A,9,8,F,E,D,C
                };


        /// <summary>
        /// Shuffle pattern that, when applied, swaps the byte-level representation of 64-bit unsigned integers
        /// </summary>
        [Op]
        public static ReadOnlySpan<byte> ByteSwap256x64u
            => new byte[32]{
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8,
                7,6,5,4,3,2,1,0,F,E,D,C,B,A,9,8
                }; 
    }
}