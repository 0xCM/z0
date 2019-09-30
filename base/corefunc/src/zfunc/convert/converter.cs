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
        public static T convert<S,T>(in S src)
            where T : unmanaged
            where S : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return converti<S,T>(ref asRef(in src));
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convertu<S,T>(ref asRef(in src));
            else
                return convertx<S,T>(ref asRef(in src));
        }

        

        [MethodImpl(Inline)]
        static T converti<S,T>(ref S src)
                where S : unmanaged
                where T : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return convert<T>(int8(ref src));
            else if(typeof(S) == typeof(short))
                return convert<T>(int16(ref src));
            else if(typeof(S) == typeof(int))
                return convert<T>(int32(ref src));
            else 
                return convert<T>(int64(ref src));                            
        }


        [MethodImpl(Inline)]
        static T convertu<S,T>(ref S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return convert<T>(uint8(ref src));
            else if(typeof(S) == typeof(ushort))
                return convert<T>(uint16(ref src));
            else if(typeof(S) == typeof(uint))
                return convert<T>(uint32(ref src));
            else
                return convert<T>(uint64(ref src));
        }




        [MethodImpl(Inline)]
        static T convertx<S,T>(ref S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(float))
                return convert<T>(float32(ref src));
            else if(typeof(S) == typeof(double))
                return convert<T>(float64(ref src));
            else if(typeof(S) == typeof(char))
                return convert<T>(char16(ref src));
            else            
                throw unsupported<T>();                            
        }


        [MethodImpl(Inline)]
        static ref sbyte int8<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        static ref byte uint8<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        static ref short int16<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        static ref ushort uint16<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        static ref int int32<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        static ref uint uint32<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        static ref long int64<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        static ref ulong uint64<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        static ref float float32<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        static ref double float64<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,double>(ref src); //*(double*)(Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        static ref char char16<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,char>(ref src);



    }
}