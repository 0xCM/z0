//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static Nats;
    using static Data;

    partial class VectorData
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
                return load<byte>(w, ByteSwap128x16u);
            else if(typeof(N) == typeof(N32))
                return load<byte>(w, ByteSwap128x32u);
            else if(typeof(N) == typeof(N64))
                return load<byte>(w, ByteSwap128x64u);
            else
                throw unsupported<N>();            
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
                return load<byte>(w, ByteSwap256x16u);
            else if(typeof(N) == typeof(N32))
                return load<byte>(w, ByteSwap256x32u);
            else if(typeof(N) == typeof(N64))
                return load<byte>(w, ByteSwap256x64u);
            else
                throw unsupported<N>();            
        }
    }
}