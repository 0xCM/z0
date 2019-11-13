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
        /// Computes the absolute value of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.abs(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.abs(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.abs(int32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.abs(int64(src)));
            else if(unsignedint<T>())
                return src;
            else return gfp.abs(src);
        }           

        /// <summary>
        /// Computes the absolute value of a primal operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(ref int8(ref src));
            else if(typeof(T) == typeof(short))
                math.abs(ref int16(ref src));
            else if(typeof(T) == typeof(int))
                math.abs(ref int32(ref src));
            else if(typeof(T) == typeof(long))
                math.abs(ref int64(ref src));
            else if(unsignedint<T>())
                return ref src;
            else gfp.abs(ref src);
            return ref src;
        }           

   }
}