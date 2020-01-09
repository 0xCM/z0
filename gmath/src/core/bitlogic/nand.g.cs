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
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Computes the bitwise nand c := ~(a & b) for integers a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.Integers)]
        public static T nand<T>(T a, T b)
            where T : unmanaged
                => nand_u(a,b);

        [MethodImpl(Inline)]
        static T nand_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.nand(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.nand(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.nand(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.nand(uint64(a), uint64(b)));
            else
                return nand_i(a,b);
        }

        [MethodImpl(Inline)]
        static T nand_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.nand(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.nand(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.nand(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.nand(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }

    }
}