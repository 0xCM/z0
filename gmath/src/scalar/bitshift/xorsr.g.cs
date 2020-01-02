//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Computes a^(a >> offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static T xorsr<T>(T a, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.xorsr(uint8(a), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xorsr(uint16(a), offset));                
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xorsr(uint32(a), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xorsr(uint64(a), offset));
            else            
                throw unsupported<T>();
        }           

    }
}