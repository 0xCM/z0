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
        /// maxtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T max<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(unsignedint<T>())
                return maxu(lhs,rhs);
            else if(signedint<T>())
                return maxi(lhs,rhs);
            else return gfp.max(lhs,rhs);
        }

        /// <summary>
        /// maxtiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T max<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(unsignedint<T>())
                maxu(ref lhs,rhs);
            else if(signedint<T>())
                maxi(ref lhs,rhs);
            else gfp.max(ref lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T maxi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.max(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.max(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.max(int32(lhs), int32(rhs)));
            else
                 return generic<T>(math.max(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T maxu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.max(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.max(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.max(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.max(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T maxi<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 math.max(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.max(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.max(ref int32(ref lhs), int32(rhs));
            else
                 math.max(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T maxu<T>(ref T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.max(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.max(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.max(ref uint32(ref lhs), uint32(rhs));
            else 
                math.max(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
