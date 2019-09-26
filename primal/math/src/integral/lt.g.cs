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
        public static bool lt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.lt(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.lt(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.lt(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.lt(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.lt(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.lt(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.lt(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.lt(uint64(lhs), uint64(rhs));
            else            
                return gfp.lt(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.lteq(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.lteq(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.lteq(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.lteq(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.lteq(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.lteq(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.lteq(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.lteq(uint64(lhs), uint64(rhs));
            else            
                return gfp.lteq(lhs,rhs);
        }


    }

}