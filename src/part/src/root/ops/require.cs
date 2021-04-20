//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        /// <summary>
        /// Insists upon invariant satisfaction
        /// </summary>
        /// <param name="invariant">It must be so, or the operation will not go</param>
        /// <param name="f">A function that emits a message to throw upon invariant failure</param>
        [MethodImpl(Inline), Op]
        public static void require(bool invariant, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);
        }

        [MethodImpl(Inline), Op]
        public static T require<T>(T src)
            where T : class
        {
            if(src == null)
                sys.@throw(string.Format("Null <{0}> argurment", typeof(T).Name));
            return src;
        }

        /// <summary>
        /// Insists upon invariant satisfaction and returns a specified value if the invariant holds
        /// </summary>
        /// <param name="invariant">It must be so, or the operation will not go</param>
        /// <param name="src">The vale to return upon success</param>
        /// <param name="f">A function that emits a message to throw upon invariant failure</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T require<T>(bool invariant, T src, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);

            return src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T require<T>(T src, Func<T,bool> f)
        {
            require(f(src),  () => $"The centre does not hold");
            return src;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] require<T>(T[] src)
        {
            if(src is null)
                sys.@throw("Null arrays are bad");
            return src;
        }

        [MethodImpl(Inline), Op]
        public static void require(bool invariant, string msg, string caller, string file, int? line)
        {
            if(!invariant)
                sys.@throw($"{msg}: Line {line} in {file}");
        }

        [MethodImpl(Inline), Op]
        public static void require(bool invariant, string msg, in AppMsgSource source)
        {
            if(!invariant)
                sys.@throw($"{msg}: {source.Format()}");
        }

    }
}