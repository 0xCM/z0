//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Computes a & (a - 1), which disables the least enabled bit
        /// </summary>
        /// <param name="a">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T loff<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.loff(uint8(a)));
            if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.loff(uint16(a)));
            if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.loff(uint32(a)));
            if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.loff(uint64(a)));
            else
                throw unsupported<T>();            
        }       
    }
}