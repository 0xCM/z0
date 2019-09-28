//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static AsIn;
    
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec256<T> blendv<T>(Vec256<T> lhs, Vec256<T> rhs, Vec256<T> control)        
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.blendv(int8(lhs), int8(rhs), int8(control)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.blendv(uint8(lhs), uint8(rhs), uint8(control)));
            else if(typematch<T,short>())
                return generic<T>(dinx.blendv(int16(lhs), int16(rhs), int16(control)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.blendv(uint16(lhs), uint16(rhs), uint16(control)));
            else if(typematch<T,int>())
                return generic<T>(dinx.blendv(int32(lhs), int32(rhs), int32(control)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.blendv(uint32(lhs), uint32(rhs), uint32(control)));
            else if(typematch<T,long>())
                return generic<T>(dinx.blendv(int64(lhs), int64(rhs), int64(control)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.blendv(uint64(lhs), uint64(rhs), uint64(control)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.blendv(float32(lhs), float32(rhs), float32(control)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.blendv(float64(lhs), float64(rhs), float64(control)));
            else 
                throw unsupported<T>();
        }
    }

}