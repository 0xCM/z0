//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T inc<T>(T lhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.inc(int8(lhs)));
            else if(typematch<T,byte>())
                return generic<T>(math.inc(uint8(lhs)));
            else if(typematch<T,short>())
                return generic<T>(math.inc(int16(lhs)));
            else if(typematch<T,ushort>())
                return generic<T>(math.inc(uint16(lhs)));
            else if(typematch<T,int>())
                return generic<T>(math.inc(int32(lhs)));
            else if(typematch<T,uint>())
                return generic<T>(math.inc(uint32(lhs)));
            else if(typematch<T,long>())
                return generic<T>(math.inc(uint64(lhs)));
            else if(typematch<T,ulong>())
                return generic<T>(math.inc(uint64(lhs)));
            else            
                return gfp.inc(lhs);
        }
        
        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T lhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                math.inc(ref int8(ref lhs));
            else if(typematch<T,byte>())
                math.inc(ref uint8(ref lhs));
            else if(typematch<T,short>())
                math.inc(ref int16(ref lhs));
            else if(typematch<T,ushort>())
                math.inc(ref uint16(ref lhs));
            else if(typematch<T,int>())
                math.inc(ref int32(ref lhs));
            else if(typematch<T,uint>())
                math.inc(ref uint32(ref lhs));
            else if(typematch<T,long>())
                math.inc(ref int64(ref lhs));
            else if(typematch<T,ulong>())
                math.inc(ref uint64(ref lhs));
            else            
                gfp.inc(ref lhs);
            return ref lhs;

        }
        
        // [MethodImpl(Inline)]
        // public static ref T inc<T>(ref T src)
        //     where T : struct
        // {
        //     if(typeof(T) == typeof(sbyte))
        //         math.inc(ref int8(ref src));
        //     else if(typeof(T) == typeof(byte))
        //         math.inc(ref uint8(ref src));
        //     else if(typeof(T) == typeof(short))
        //         math.inc(ref int16(ref src));
        //     else if(typeof(T) == typeof(ushort))
        //         math.inc(ref uint16(ref src));
        //     else if(typeof(T) == typeof(int))
        //         math.inc(ref int32(ref src));
        //     else if(typeof(T) == typeof(uint))
        //         math.inc(ref uint32(ref src));
        //     else if(typeof(T) == typeof(long))
        //         math.inc(ref int64(ref src));
        //     else if(typeof(T) == typeof(ulong))
        //         math.inc(ref uint64(ref src));
        //     else if(typeof(T) == typeof(float))
        //         fmath.inc(ref float32(ref src));
        //     else if(typeof(T) == typeof(double))
        //         fmath.inc(ref float64(ref src));
        //     else            
        //          throw unsupported<T>();                

        //     return ref src;
        // }           

    }
}