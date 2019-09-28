//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static AsIn;
    
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static ref Vec128<T> broadcast<T>(in T src, out Vec128<T> dst)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                dst = generic<T>(dinx.broadcast(in int8(in src), out Vec128<sbyte> x));
            else if(typematch<T,byte>())
                dst = generic<T>(dinx.broadcast(in uint8(in src), out Vec128<byte> x));
            else if(typematch<T,short>())
                dst = generic<T>(dinx.broadcast(in int16(in src), out Vec128<short> x));
            else if(typematch<T,ushort>())
                dst = generic<T>(dinx.broadcast(in uint16(in src), out Vec128<ushort> x));
            else if(typematch<T,int>())
                dst = generic<T>(dinx.broadcast(in int32(in src), out Vec128<int> x));
            else if(typematch<T,uint>())
                dst = generic<T>(dinx.broadcast(in uint32(in src), out Vec128<uint> x));
            else if(typematch<T,long>())
                dst = generic<T>(dinx.broadcast(in int64(in src), out Vec128<long> x));
            else if(typematch<T,ulong>())
                dst = generic<T>(dinx.broadcast(in uint64(in src), out Vec128<ulong> x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(dfp.broadcast(in float32(in src), out Vec128<float> x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(dfp.broadcast(in float64(in src), out Vec128<double> x));
            else 
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<T> broadcast<T>(in T src, out Vec256<T> dst)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                dst = generic<T>(dinx.broadcast(in int8(in src), out Vec256<sbyte> x));
            else if(typematch<T,byte>())
                dst = generic<T>(dinx.broadcast(in uint8(in src), out Vec256<byte> x));
            else if(typematch<T,short>())
                dst = generic<T>(dinx.broadcast(in int16(in src), out Vec256<short> x));
            else if(typematch<T,ushort>())
                dst = generic<T>(dinx.broadcast(in uint16(in src), out Vec256<ushort> x));
            else if(typematch<T,int>())
                dst = generic<T>(dinx.broadcast(in int32(in src), out Vec256<int> x));
            else if(typematch<T,uint>())
                dst = generic<T>(dinx.broadcast(in uint32(in src), out Vec256<uint> x));
            else if(typematch<T,long>())
                dst = generic<T>(dinx.broadcast(in int64(in src), out Vec256<long> x));
            else if(typematch<T,ulong>())
                dst = generic<T>(dinx.broadcast(in uint64(in src), out Vec256<ulong> x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(dfp.broadcast(in float32(in src), out Vec256<float> x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(dfp.broadcast(in float64(in src), out Vec256<double> x));
            else 
                throw unsupported<T>();
            return ref dst;
        }
    }

}