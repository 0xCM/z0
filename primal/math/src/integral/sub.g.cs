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
        public static T sub<T>(T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>((sbyte)(int8(lhs) - int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>((byte)(uint8(lhs) - uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>((short)(int16(lhs) - int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>((ushort)(uint16(lhs) - uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(int32(lhs) - int32(rhs));
            else if(typematch<T,uint>())
                return generic<T>(uint32(lhs) - uint32(rhs));
            else if(typematch<T,long>())
                return generic<T>(int64(lhs) - int64(rhs));
            else if(typematch<T,ulong>())
                return generic<T>(uint64(lhs) - uint64(rhs));
            else if(typematch<T,float>())
                return generic<T>(float32(lhs) - float32(rhs));
            else if(typematch<T,double>())
                return generic<T>(float64(lhs) - float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.sub(ref int8(ref lhs), int8(in rhs));
            else if(typematch<T,byte>())
                math.sub(ref uint8(ref lhs), uint8(in rhs));
            else if(typematch<T,short>())
                math.sub(ref int16(ref lhs), int16(in rhs));
            else if(typematch<T,ushort>())
                math.sub(ref uint16(ref lhs), uint16(in rhs));
            else if(typematch<T,int>())
                math.sub(ref int32(ref lhs), int32(in rhs));
            else if(typematch<T,uint>())
                math.sub(ref uint32(ref lhs), uint32(in rhs));
            else if(typematch<T,long>())
                math.sub(ref int64(ref lhs), int64(in rhs));
            else if(typematch<T,ulong>())
                math.sub(ref uint64(ref lhs), uint64(in rhs));
            else if(typematch<T,float>())
                math.sub(ref float32(ref lhs), float32(in rhs));
            else if(typematch<T,double>())
                math.sub(ref float64(ref lhs), float64(in rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}
