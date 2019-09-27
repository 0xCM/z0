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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    
    using static zfunc;
    using static As;
    

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.sub(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.sub(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.sub(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.sub(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.sub(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.sub(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(dinx.sub(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.sub(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.fsub(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.fsub(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> sub<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
             if(typematch<T,sbyte>())
                return generic<T>(dinx.sub(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.sub(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.sub(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.sub(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.sub(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.sub(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(dinx.sub(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.sub(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.fsub(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.fsub(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
       }
            


    }
}