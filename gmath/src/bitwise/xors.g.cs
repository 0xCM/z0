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

    partial class gmath
    {
        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static T xors<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.xors(uint8(a), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xors(uint16(a), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xors(uint32(a), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xors(uint64(a), offset));
            else            
                throw unsupported<T>();
        }           

    }
}