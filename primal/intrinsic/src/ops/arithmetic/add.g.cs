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
        public static Vector128<T> add<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.add(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.add(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.add(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.add(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.add(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.add(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(dinx.add(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.add(uint64(lhs), uint64(rhs)));
            else return gfp.add(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> add<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.add(lhs.As<T,sbyte>(), rhs.As<T,sbyte>()));
            else if(typematch<T,byte>())
                return generic<T>(dinx.add(lhs.As<T,byte>(), rhs.As<T,byte>()));
            else if(typematch<T,short>())
                return generic<T>(dinx.add(lhs.As<T,short>(), rhs.As<T,short>()));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.add(lhs.As<T,ushort>(), rhs.As<T,ushort>()));
            else if(typematch<T,int>())
                return generic<T>(dinx.add(lhs.As<T,int>(), rhs.As<T,int>()));
            else if(typematch<T,uint>())
                return generic<T>(dinx.add(lhs.As<T,uint>(), rhs.As<T,uint>()));
            else if(typematch<T,long>())
                return generic<T>(dinx.add(lhs.As<T,long>(), rhs.As<T,long>()));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.add(lhs.As<T,ulong>(), rhs.As<T,ulong>()));
            else return gfp.add(lhs,rhs);
        }    


    }
}
