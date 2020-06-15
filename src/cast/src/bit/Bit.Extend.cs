//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class XTend
    {
        public static string Format(this IEnumerable<bit> src, bool reversed = true)
        {
            var chars = src.Select(x => x.ToChar()).ToArray();
            if(reversed)
                return new string(chars.Reverse());
            else
                return new string(chars);            
        }

        [MethodImpl(Inline)]
        public static void OnNone(this bit x, Action f)
        {
            if(!x)
                f();
        }

        [MethodImpl(Inline)]
        public static void OnSome(this bit x, Action f)
        {
            if(x)
                f();
        }

        /// <summary>
        /// Reverses an array in-place
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        static T[] Reverse<T>(this T[] src)
        {
            Array.Reverse(src);
            return src;
        }

        [MethodImpl(Inline)]
        public static UnaryPredicate<T> ToUnaryPredicate<T>(this System.Func<T,bit> f)
            => new UnaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static Z0.BinaryPredicate<T> ToBinaryPredicate<T>(this System.Func<T,T,bit> f)
            => new Z0.BinaryPredicate<T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,bit> ToFunc<T>(this UnaryPredicate<T> f)
            => new System.Func<T,bit>(f);

        [MethodImpl(Inline)]
        public static System.Func<T,T,bit> ToFunc<T>(this BinaryPredicate<T> f)
            => new System.Func<T,T,bit>(f);
    }
}