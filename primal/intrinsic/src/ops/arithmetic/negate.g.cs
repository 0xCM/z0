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
        public static Vector128<T> negate<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.negate(int8(src)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.negate(uint8(src)));
            else if(typematch<T,short>())
                return generic<T>(dinx.negate(int16(src)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.negate(uint16(src)));
            else if(typematch<T,int>())
                return generic<T>(dinx.negate(int32(src)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.negate(uint32(src)));
            else if(typematch<T,long>())
                return generic<T>(dinx.negate(int64(src)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.negate(uint64(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> negate<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.negate(int8(src)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.negate(uint8(src)));
            else if(typematch<T,short>())
                return generic<T>(dinx.negate(int16(src)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.negate(uint16(src)));
            else if(typematch<T,int>())
                return generic<T>(dinx.negate(int32(src)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.negate(uint32(src)));
            else if(typematch<T,long>())
                return generic<T>(dinx.negate(int64(src)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.negate(uint64(src)));
            else 
                throw unsupported<T>();
        }
    }
}