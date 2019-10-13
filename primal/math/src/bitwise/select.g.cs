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

        [MethodImpl(Inline)]
        public static T select<T>(T a, T b, T c)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.select(uint8(a), uint8(b), uint8(c)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.select(uint16(a), uint16(b), uint16(c)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.select(uint32(a), uint32(b), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.select(uint64(a), uint64(b), uint64(b)));
            else
                throw unsupported<T>();
        }
    }

}