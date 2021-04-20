//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Structs
    {
        const NumericKind Closure = Integers;

        /// <summary>
        /// Determines whether a structural value is 'empty':
        /// A structural value is *empty* if, when rendered as an array of bytes, each aelement of the array is zero.
        /// </summary>
        /// <param name="src">The value to adjudicate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool empty2<T>(in T src)
            where T : struct
        {
            var x = memory.bytes(src);
            var y = memory.bytes(default(T));
            var length = y.Length;

            if(x.Length != length)
                return false;

            for(var i=0u; i<length; i++)
                if(skip(x,i) != 0)
                    return false;

            return true;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> edit<T>(in T src)
            where T : struct
                => bytes(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view<T>(in T src)
            where T : struct
                => bytes(src);

        [MethodImpl(Inline), Op]
        public static uint hash<T>(in T src)
            where T : struct
                => alg.hash.calc(bytes(src));

        /// <summary>
        /// Determines whether all bytes of a structural value are zero
        /// </summary>
        /// <param name="src">The value to evaluate</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool empty<T>(in T src)
            where T : struct
        {
            ref var data = ref @as<T,byte>(src);
            var count = size<T>();
            for(var i=0u; i<count; i++)
                if(skip(data,i) != 0)
                    return false;
            return true;
        }

        /// <summary>
        /// Determines whether each corresponding bytes of two structural values are identical
        /// </summary>
        /// <param name="x">The first value</param>
        /// <param name="y">The second value</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool eq<T>(in T x, in T y)
            where T : struct
        {
            var count = (uint)size<T>();
            ref readonly var bx = ref @as<T,byte>(x);
            ref readonly var by = ref @as<T,byte>(y);
            for(var i=0; i<count; i++)
                if(skip(bx,i) != skip(by,i))
                    return false;
            return true;
        }

        /// <summary>
        /// Determines whether at least one byte of two structural values differs
        /// </summary>
        /// <param name="x">The first value</param>
        /// <param name="y">The second value</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool neq<T>(in T x, in T y)
            where T : struct
        {
            var count = memory.size<T>();
            ref readonly var bx = ref @as<T,byte>(x);
            ref readonly var by = ref @as<T,byte>(y);
            for(var i=0; i<count; i++)
                if(skip(bx,i) != skip(by,i))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether at least one byte of a structural value is nonzero
        /// </summary>
        /// <param name="src">The value to evaluate</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool nonempty<T>(in T src)
            where T : struct
        {
            ref var data = ref @as<T,byte>(src);
            var count = size<T>();
            for(var i=0u; i<count; i++)
                if(skip(data,i) != 0)
                    return true;
            return false;
        }
    }
}