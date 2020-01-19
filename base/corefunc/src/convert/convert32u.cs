//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;
    using static As;

    partial class Converter
    {
        [MethodImpl(Inline), Op("convert32u"), PrimalClosures(PrimalKind.All)]
        public static T convert<T>(uint src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return converti<T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convertu<T>(src);
            else
                return convertx<T>(src);
        }

        [MethodImpl(Inline)]
        static T converti<T>(uint src)
        {
            if(typeof(T) == typeof(sbyte))
                return AsIn.generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return AsIn.generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return AsIn.generic<T>((int)src);
            else  
                return AsIn.generic<T>((long)src);           
        }

        [MethodImpl(Inline)]
        static T convertu<T>(uint src)
        {
            if(typeof(T) == typeof(byte))
                return AsIn.generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return AsIn.generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return AsIn.generic<T>((uint)src);
            else  
                return AsIn.generic<T>((ulong)src);
        }

        [MethodImpl(Inline)]
        static T convertx<T>(uint src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(((float)(int)src));
            else if(typeof(T) == typeof(double))
                return generic<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else            
                 return unhandled<uint,T>(src);
        }
    }
}