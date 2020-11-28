//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct Sources
    {
        /// <summary>
        /// Produces the next value from a specified <see cref='IDomainValueSource'/> source subject to specified domain constraints
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="max">The maximum value to produce</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IDomainValueSource source, T max)
            where T : unmanaged
                => source.Next<T>(max);

        /// <summary>
        /// Produces the next value from a specified <see cref='IDomainValueSource'/> source subject to specified domain constraints
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="min">The minimum value to produce</param>
        /// <param name="max">The maximum value to produce</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IDomainValueSource source, T min, T max)
            where T : unmanaged
                => source.Next<T>(min, max);


        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static bool next<T>(in ValuePipe<T> pipe, out T dst)
            where T : struct
        {
            if(pipe.Buffer.TryTake(out dst))
                return true;
            dst = default;
            return false;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool next<T>(in Pipe<T> pipe, out T dst)
        {
            if(pipe.Buffer.TryTake(out dst))
                return true;
            dst = default;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool next<S,T>(in ValuePipe<S,T> pipe, out T dst)
            where S : struct
            where T : struct
        {
            if(pipe.Buffer.TryTake(out var src))
            {
                dst = z.@as<S,T>(src);
                return true;
            }
            dst = default;
            return false;
        }
    }
}