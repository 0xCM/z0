//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class mathspan
    {
        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(mathspan.dot(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(mathspan.dot(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(mathspan.dot(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(mathspan.dot(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(mathspan.dot(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(mathspan.dot(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(mathspan.dot(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(mathspan.dot(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.dot(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.dot(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(sbyte);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static byte dot(ReadOnlySpan<byte> lhs,ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(byte);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static short dot(ReadOnlySpan<short> lhs,ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(short);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ushort);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(int);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(uint);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(long);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        static ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ulong);
            for(var i = 0; i< len; i++)
                dst = math.fma(lhs[i], rhs[i], dst);
            return dst;                
        }


    }

}