//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gmath
    {
        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(T src, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>((sbyte)(int8(src) << offset));
            else if(typematch<T,byte>())
                return generic<T>((byte)(uint8(src) << offset));
            else if(typematch<T,short>())
                return generic<T>((short)(int16(src) << offset));
            else if(typematch<T,ushort>())
                return generic<T>((ushort)(uint16(src) << offset));
            else if(typematch<T,int>())
                return generic<T>(int32(src) << offset);
            else if(typematch<T,uint>())
                return generic<T>(uint32(src) << offset);
            else if(typematch<T,long>())
                return generic<T>(int64(src) << offset);
            else if(typematch<T,ulong>())
                return generic<T>(uint64(src) << offset);
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sal<T>(ref T src, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.sal(ref int8(ref src), offset);
            else if(typematch<T,byte>())
                math.sal(ref uint8(ref src), offset);
            else if(typematch<T,short>())
                math.sal(ref int16(ref src), offset);
            else if(typematch<T,ushort>())
                math.sal(ref uint16(ref src), offset);
            else if (typeof(T) == typeof(int))
                math.sal(ref int32(ref src), offset);
            else if (typeof(T) == typeof(uint))
                math.sal(ref uint32(ref src), offset);
            else if (typeof(T) == typeof(long))
                math.sal(ref int64(ref src), offset);
            else if (typeof(T) == typeof(ulong))
                math.sal(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(in T src, in uint offset)
            where T : struct
                => sal(src, (int)offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(in T src, in ulong offset)
            where T : struct
                => sal(src, (int)offset);
    }

}