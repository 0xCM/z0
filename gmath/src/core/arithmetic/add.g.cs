//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static AsIn;

    partial class gmath
    {                
        /// <summary>
        /// Adds two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static T add<T>(T a, T b)
            where T : unmanaged
                => add_u(a,b);

        [MethodImpl(Inline)]
        static T add_u<T>(T a, T b)
            where T : unmanaged                
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.add(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.add(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.add(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.add(uint64(a),  uint64(b)));
            else    
                return add_i(a,b);
        }

        [MethodImpl(Inline)]
        static T add_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.add(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.add(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.add(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.add(int64(a), int64(b)));
            else
                return gfp.add(a,b);
        }

    }
}
