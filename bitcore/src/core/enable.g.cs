//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                       
        /// <summary>
        /// Enables an index-identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static T enable<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return enable_u(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return enable_i(src,pos);
            else 
                return enable_f(src,pos);
        }


        [MethodImpl(Inline)]
        static T enable_i<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.enable(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.enable(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.enable(int32(src), pos));
            else 
                 return generic<T>(Bits.enable(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T enable_u<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.enable(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.enable(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.enable(uint32(src), pos));
            else 
                 return generic<T>(Bits.enable(uint64(src), pos));
            
        }

        [MethodImpl(Inline)]
        static T enable_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.enable(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.enable(float64(src), pos));
            else
                throw unsupported<T>();
        }
    }
}