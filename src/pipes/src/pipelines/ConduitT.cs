//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a connection from a source <see cref='Pipe{T}'/> to a target <see cref='Pipe{T}'/>
    /// </summary>
    public readonly struct Conduit<T> : IConduit<Conduit<T>,T>
    {
        readonly Pipe<T> Source;

        readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        internal Conduit(Pipe<T> src, Pipe<T> dst)
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