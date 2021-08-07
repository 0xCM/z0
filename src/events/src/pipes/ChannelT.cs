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
    public readonly struct Channel<T> : IChannel<Channel<T>,T>
    {
        readonly Pipe<T> Source;

        readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        public Channel(Pipe<T> src, Pipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow()
        {
            while(Source.Emit(out var dst))
                Target.Deposit(dst);
        }
    }
}