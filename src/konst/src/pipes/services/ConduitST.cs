//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a connection from a source <see cref='Pipe{S,T}'/> to a target <see cref='Pipe{T}'/>
    /// </summary>
    /// <typeparam name="S">The source input type</typeparam>
    /// <typeparam name="T">The source output type/target input type</typeparam>
    public readonly struct Conduit<S,T> : IConduit<Conduit<S,T>,S>
    {
        readonly Pipe<S,T> Source;

        readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        public Conduit(Pipe<S,T> src, Pipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow()
        {
            while(Source.Next(out var dst))
                Target.Deposit(dst);
        }
    }
}