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
        public static T nor<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.nor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.nor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.nor(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.nor(uint64(lhs), uint64(rhs)));
            else
                throw unsupported<T>();
        }


    }

}