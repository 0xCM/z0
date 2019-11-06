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
        /// Computes the average of unsigned integral operands, rounding toward zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T avgz<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.avgz(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avgz(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avgz(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avgz(uint64(a), uint64(b)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the average unsigned integral operands, rounding toward zero, and overwrites the left operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T avgz<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.avgz(ref uint8(ref a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                math.avgz(ref uint16(ref a), uint16(b));
            else if(typeof(T) == typeof(uint))
                math.avgz(ref uint32(ref a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                math.avgz(ref uint64(ref a), uint64(b));
            else 
                throw unsupported<T>();
            return ref a;
        }


        /// <summary>
        /// Computes the average of unsigned integral operands, rounding toward infinity
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T avgi<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.avgi(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avgi(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avgi(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avgi(uint64(a), uint64(b)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the average unsigned integral operands, rounding toward infinity, and overwrites the left operand with the result
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T avgi<T>(ref T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                math.avgi(ref uint8(ref a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                math.avgi(ref uint16(ref a), uint16(b));
            else if(typeof(T) == typeof(uint))
                math.avgi(ref uint32(ref a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                math.avgi(ref uint64(ref a), uint64(b));
            else 
                throw unsupported<T>();
            return ref a;
        }

    }
}
