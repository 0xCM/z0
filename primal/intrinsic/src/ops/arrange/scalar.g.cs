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
    using Z0;
    using static As;

    using static zfunc;
    
    partial class ginx
    {                    

        /// <summary>
        /// Loads the source value into the first component of a new vector
        /// </summary>
        /// <param name="src">The source scalar</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> scalar<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return scalar_u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return scalar_i(in src);
            else 
                return scalar_f(in src);
        }        

        [MethodImpl(Inline)]
        static Vector128<T> scalar_i<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Vector128.CreateScalarUnsafe(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Vector128.CreateScalarUnsafe(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Vector128.CreateScalarUnsafe(int32(src)));
            else 
                return generic<T>(Vector128.CreateScalarUnsafe(int64(src)));
        }        

        [MethodImpl(Inline)]
        static Vector128<T> scalar_u<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte))
                return generic<T>(Vector128.CreateScalarUnsafe(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Vector128.CreateScalarUnsafe(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Vector128.CreateScalarUnsafe(uint32(src)));
            else 
                return generic<T>(Vector128.CreateScalarUnsafe(uint64(src)));
        }        

        [MethodImpl(Inline)]
        static Vector128<T> scalar_f<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(float))
                return generic<T>(Vector128.CreateScalarUnsafe(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Vector128.CreateScalarUnsafe(float64(src)));
            else 
                throw unsupported<T>();
        }        


    }

}