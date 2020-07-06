//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {            
        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<sbyte> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<byte> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<short> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<ushort> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<int> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<uint> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<ulong> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Calculates a combined hash for a sequence integral values
        /// </summary>
        /// <param name="src">The value source</param>
        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<long> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0u; i<src.Length; i++)
                x = hash(x, skip(src,i)) * FnvPrime;
            return x;
        }
    }
}