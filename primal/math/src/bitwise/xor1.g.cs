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
        [MethodImpl(Inline)]
        public static T xor1<T>(T a)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.xor1(uint8(a)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.xor1(uint16(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.xor1(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.xor1(uint64(a)));
            else
                throw unsupported<T>();
        }


    }

}