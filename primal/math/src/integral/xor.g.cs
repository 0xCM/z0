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
    using static AsIn;

    partial class gmath
    {        

        [MethodImpl(Inline)]
        public static T xor<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.xor(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(math.xor(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(math.xor(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(math.xor(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(math.xor(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(math.xor(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(math.xor(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(math.xor(uint64(lhs), uint64(rhs)));
            else            
                return gfp.xor(lhs,rhs);

        }


        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                math.xor(ref int8(ref lhs), int8(rhs));
            else if(typematch<T,byte>())
                math.xor(ref uint8(ref lhs), uint8(rhs));
            else if(typematch<T,short>())
                math.xor(ref int16(ref lhs), int16(rhs));
            else if(typematch<T,ushort>())
                math.xor(ref uint16(ref lhs), uint16(rhs));
            else if(typematch<T,int>())
                math.xor(ref int32(ref lhs), int32(rhs));
            else if(typematch<T,uint>())
                math.xor(ref uint32(ref lhs), uint32(rhs));
            else if(typematch<T,long>())
                math.xor(ref int64(ref lhs), int64(rhs));
            else if(typematch<T,ulong>())
                math.xor(ref uint64(ref lhs), uint64(rhs));
            else            
                gfp.xor(ref lhs,rhs);
        
            return ref lhs;

        }

    }
}
