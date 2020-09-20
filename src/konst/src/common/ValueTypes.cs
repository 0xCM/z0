//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ValueTypes
    {
        /// <summary>
        /// Determines whether at least one byte of a structural value is nonzero
        /// </summary>
        /// <param name="src">The value to evaluate</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void digits<T>(in T src, Span<HexCodeLo> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = Hex.code(LowerCase, Sized.cut(d, w4));
                seek(dst, j--) = Hex.code(LowerCase, Sized.srl(d, n4, w4));
            }
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ReadOnlySpan<HexCodeLo> digits<T>(in T src, LowerCased @case)
            where T : struct
        {
            var count = size<T>();
            var dst = span<HexCodeLo>(count*2);
            digits(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static string format<T>(in T src)
            where T : struct
        {
            var count = size<T>();
            var dst = span<char>(count*2);
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)Hex.code(LowerCase, Sized.cut(d, w4));
                seek(dst, j--) = (char)Hex.code(LowerCase, Sized.srl(d, n4, w4));
            }

            return text.format(dst);
        }

        /// <summary>
        /// Determines whether at least one byte of two structural values differs
        /// </summary>
        /// <param name="x">The first value</param>
        /// <param name="y">The second value</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool neq<T>(in T x, in T y)
            where T : struct
        {
            var count = (uint)size<T>();
            ref readonly var bx = ref @as<T,byte>(x);
            ref readonly var by = ref @as<T,byte>(y);

            for(var i=0; i<count; i++)
                if(skip(bx,i) != skip(by,i))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether each corresponding bytes of two structural values are identical
        /// </summary>
        /// <param name="x">The first value</param>
        /// <param name="y">The second value</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
                => z.hash(bytes(src));
    }
}