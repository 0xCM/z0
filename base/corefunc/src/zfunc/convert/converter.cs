//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using static AsIn;
    using static As;
    
    using static zfunc;

    public static partial class Converter
    {
        [MethodImpl(Inline)]
        public static T convert<S,T>(in S src, out T dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return converti<S,T>(src, out dst);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convertu<S,T>(src, out dst);
            else
                return convertx<S,T>(src, out dst);
        }

        [MethodImpl(Inline)]   
        public static T convert<S,T>(S src)
            where T : unmanaged
            where S : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return converti<S,T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convertu<S,T>(src);
            else
                return convertx<S,T>(src);
        }

        
        [MethodImpl(Inline)]
        static T converti<S,T>(in S src, out T dst)
                where S : unmanaged
                where T : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return convert(int8(in src), out dst);
            else if(typeof(S) == typeof(short))
                return convert(int16(in src), out dst);
            else if(typeof(S) == typeof(int))
                return convert(int32(in src), out dst);
            else 
                return convert(int64(in src), out dst);                            
        }

        [MethodImpl(Inline)]
        static T converti<S,T>(S src)
                where S : unmanaged
                where T : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return convert<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return convert<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return convert<T>(int32(src));
            else 
                return convert<T>(int64(src));                            
        }


        [MethodImpl(Inline)]
        static T convertu<S,T>(in S src, out T dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return convert(uint8(in src), out dst);
            else if(typeof(S) == typeof(ushort))
                return convert(uint16(in src), out dst);
            else if(typeof(S) == typeof(uint))
                return convert(uint32(in src), out dst);
            else
                return convert(uint64(in src), out dst);
        }

        [MethodImpl(Inline)]
        static T convertu<S,T>(in S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return convert<T>(uint8(in src));
            else if(typeof(S) == typeof(ushort))
                return convert<T>(uint16(in src));
            else if(typeof(S) == typeof(uint))
                return convert<T>(uint32(in src));
            else
                return convert<T>(uint64(in src));
        }


        [MethodImpl(Inline)]
        static T convertx<S,T>(in S src, out T dst)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(float))
                return convert(float32(in src), out dst);
            else if(typeof(S) == typeof(double))
                return convert(float64(in src), out dst);
            else if(typeof(S) == typeof(char))
                return convert(char16(in src), out dst);
            else            
                throw unsupported<T>();                            
        }


        [MethodImpl(Inline)]
        static T convertx<S,T>(in S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(float))
                return convert<T>(float32(in src));
            else if(typeof(S) == typeof(double))
                return convert<T>(float64(in src));
            else if(typeof(S) == typeof(char))
                return convert<T>(char16(in src));
            else            
                throw unsupported<T>();                            
        }


        [MethodImpl(Inline)]
        static unsafe sbyte int8<T>(in T src)
            where T : unmanaged
                => *(sbyte*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe byte uint8<T>(in T src)
            where T : unmanaged
                => *(byte*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe short int16<T>(in T src)
            where T : unmanaged
                => *(short*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe ushort uint16<T>(in T src)
            where T : unmanaged
                => *(ushort*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe int int32<T>(in T src)
            where T : unmanaged
                => *(int*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe uint uint32<T>(in T src)
            where T : unmanaged
                => *(uint*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe long int64<T>(in T src)
            where T : unmanaged
                => *(long*)(Unsafe.AsPointer(ref asRef(in src)));

        [MethodImpl(Inline)]
        static unsafe ulong uint64<T>(in T src)
            where T : unmanaged
                => *(ulong*)(Unsafe.AsPointer(ref asRef(in src)));

        // [MethodImpl(Inline)]
        // static unsafe float float32<T>(in T src)
        //     where T : unmanaged
        //         => *(float*)(Unsafe.AsPointer(ref asRef(in src)));

        // [MethodImpl(Inline)]
        // static unsafe double float64<T>(in T src)
        //     where T : unmanaged
        //         => *(double*)(Unsafe.AsPointer(ref asRef(in src)));

        // [MethodImpl(Inline)]
        // static unsafe char char16<T>(in T src)
        //     where T : unmanaged
        //         => *(char*)(Unsafe.AsPointer(ref asRef(in src)));



    }
}