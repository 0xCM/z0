//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Pipes
    {
       [MethodImpl(Inline)]
       public static void deposit<S,T>(in DataPipe<S,T> pipe, in S src)
            where S : struct
            where T : struct
                => pipe.Buffer.Add(src);

        [MethodImpl(Inline), Closures(Closure)]
        public static void deposit<T>(in DataPipe<T> pipe, in T src)
            where T : struct
                => pipe.Buffer.Add(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(in Pipe<T> pipe, T src)
            => pipe.Buffer.Add(src);
    }
}