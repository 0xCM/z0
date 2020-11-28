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

    partial struct Pipes
    {
        [Op, Closures(Closure)]
        public static void flow<T>(in ValuePipeConnector<T> connector, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                connector.Source.Deposit(skip(src,i));

            while(connector.Source.Next(out var dst))
                connector.Target.Deposit(dst);
        }

        public static void flow<S,T>(in ValuePipeConnector<S,T> connector, ReadOnlySpan<S> src)
            where S : struct
            where T : struct
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                connector.Source.Deposit(skip(src,i));

            while(connector.Source.Next(out var dst))
                connector.Target.Deposit(dst);
        }
    }
}