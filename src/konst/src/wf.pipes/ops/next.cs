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
        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static bool next<T>(in DataPipe<T> pipe, out T dst)
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
        public static bool next<S,T>(in DataPipe<S,T> pipe, out T dst)
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