//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {        
        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extendint to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static T lomask<N,T>()
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(Bits.lomask<N>());

        /// <summary>
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint log2<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.log2(uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.log2(uint16(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.log2(uint32(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.log2(uint64(src));
            else 
                throw unsupported<T>();
        }

    }

}