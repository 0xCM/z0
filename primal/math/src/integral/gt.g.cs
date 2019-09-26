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
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.gt(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.gt(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.gt(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.gt(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.gt(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.gt(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.gt(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.gt(uint64(lhs), uint64(rhs));
            else            
                return gfp.gt(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return math.gteq(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.gteq(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.gteq(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.gteq(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.gteq(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.gteq(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.gteq(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.gteq(uint64(lhs), uint64(rhs));
            else            
                return gfp.gteq(lhs,rhs);
        }

    }


}