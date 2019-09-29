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
        
    using static As;
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {        
        [MethodImpl(Inline)]
        static unsafe Vec256<T> lddqu256u<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Avx2.LoadDquVector256(constptr(in uint8(in src))));
            else if(typematch<T,ushort>())
                return generic<T>(Avx2.LoadDquVector256(constptr(in uint16(in src))));
            else if(typematch<T,uint>())
                return generic<T>(Avx2.LoadDquVector256(constptr(in uint32(in src))));
            else
                return generic<T>(Avx2.LoadDquVector256(constptr(in uint64(in src))));
        }
        
        [MethodImpl(Inline)]
        static unsafe Vec256<T> lddqu256i<T>(in T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Avx2.LoadDquVector256(constptr(in int8(in src))));
            else if(typematch<T,short>())
                return generic<T>(Avx2.LoadDquVector256(constptr(in int16(in src))));
            else if(typematch<T,int>())
                return generic<T>(Avx2.LoadDquVector256(constptr(in int32(in src))));
            else
                return generic<T>(Avx2.LoadDquVector256(constptr(in uint64(in src))));
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<T> lddqu256<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || 
                typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return lddqu256u(in src);
            else if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || 
                typeof(T) == typeof(int) || typeof(T) == typeof(long))
                    return lddqu256i(in src);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec128<T> lddqu128<T>(in T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.lddqu128(in int8(in src)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.lddqu128(in uint8(in src)));
            else if(typematch<T,short>())
                return generic<T>(dinx.lddqu128(in int16(in src)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.lddqu128(in uint16(in src)));
            else if(typematch<T,int>())
                return generic<T>(dinx.lddqu128(in int32(in src)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.lddqu128(in uint32(in src)));
            else if(typematch<T,long>())
                return generic<T>(dinx.lddqu128(in int64(in src)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.lddqu128(in uint64(in src)));
            else
                throw unsupported<T>();
        }

    }

}
