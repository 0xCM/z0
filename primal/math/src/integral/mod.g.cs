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
        public static T mod<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.mod(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(math.mod(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(math.mod(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(math.mod(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(math.mod(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(math.mod(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(math.mod(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(math.mod(uint64(lhs), uint64(rhs)));
            else            
                return gfp.mod(lhs,rhs);

        }

        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                math.mod(ref int8(ref lhs), int8(rhs));
            else if(typematch<T,byte>())
                math.mod(ref uint8(ref lhs), uint8(rhs));
            else if(typematch<T,short>())
                math.mod(ref int16(ref lhs), int16(rhs));
            else if(typematch<T,ushort>())
                math.mod(ref uint16(ref lhs), uint16(rhs));
            else if(typematch<T,int>())
                math.mod(ref int32(ref lhs), int32(rhs));
            else if(typematch<T,uint>())
                math.mod(ref uint32(ref lhs), uint32(rhs));
            else if(typematch<T,long>())
                math.mod(ref int64(ref lhs), int64(rhs));
            else if(typematch<T,ulong>())
                math.mod(ref uint64(ref lhs), uint64(rhs));
            else            
                gfp.mod(ref lhs,rhs);
        
            return ref lhs;

        }

    }
}
