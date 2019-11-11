//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Computes log2(maxval[T] + 1)
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint log2<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return 8;
            else if(typeof(T) == typeof(ushort))
                return 16;
            else if(typeof(T) == typeof(uint))
                return 32;
            else if(typeof(T) == typeof(ulong))
                return 64;
            else
                throw unsupported<T>();
            
        }

        
        [MethodImpl(Inline)]
        public static T log2<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.log2(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.log2(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.log2(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.log2(uint64(a)));
            else
                throw unsupported<T>();
        }


    }

}