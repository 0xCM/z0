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
        public static bool eq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return math.eq(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.eq(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.eq(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.eq(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.eq(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.eq(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.eq(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.eq(uint64(lhs), uint64(rhs));
            else            
                return gfp.eq(lhs,rhs);

        }

    }
}