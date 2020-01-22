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

    partial class gmath
    {
        /// <summary>
        /// Returns true if the difference between two operands is within a specified tolerance
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="delta">The tolerance</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static bit within<T>(T a, T b, T delta)
            where T : unmanaged
                => within_u(a,b,delta);

        [MethodImpl(Inline)]
        static bit within_u<T>(T a, T b, T delta)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.within(convert<T,uint>(a), convert<T,uint>(b), convert<T,uint>(delta));
            else if(typeof(T) == typeof(ushort))
                return math.within(convert<T,uint>(a), convert<T,uint>(b), convert<T,uint>(delta));
            else if(typeof(T) == typeof(uint))
                return math.within(uint32(a), uint32(b), uint32(delta));
            else if(typeof(T) == typeof(ulong))
                return math.within(uint64(a), uint64(b), uint64(delta));
            else
                return within_i(a,b,delta);
        }

        [MethodImpl(Inline)]
        static bit within_i<T>(T a, T b, T delta)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.within(convert<T,int>(a), convert<T,int>(b), convert<T,int>(delta));
            else if(typeof(T) == typeof(short))
                return math.within(convert<T,int>(a), convert<T,int>(b), convert<T,int>(delta));
            else if(typeof(T) == typeof(int))
                return math.within(int32(a), int32(b), int32(delta));
            else if(typeof(T) == typeof(long))
                return math.within(int64(a), int64(b), int64(delta));
            else
                return gfp.within(a,b,delta);

        }
    }
}