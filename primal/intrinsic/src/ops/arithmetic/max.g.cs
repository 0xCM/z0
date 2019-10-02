//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    
    using static As;

    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static Vec128<T> max<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.max(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.max(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.max(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.max(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.max(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.max(uint32(lhs), uint32(rhs)));
            else 
                throw unsupported<T>();
        }
         
       [MethodImpl(Inline)]
       public static Vec256<T> max<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.max(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.max(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.max(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.max(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.max(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.max(uint32(lhs), uint32(rhs)));
            else 
                throw unsupported<T>();
        }        
    }
}