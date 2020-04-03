//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class Context
    {
        /// <summary>
        /// Wraps a context over a value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="C">The value type</typeparam>
        [MethodImpl(Inline)]
        public static IContext<C> from<C>(C src)
            =>  new Context<C>(src);
    }

    readonly struct Context<C> : IContext<C>
    {
        readonly C context;
                
        [MethodImpl(Inline)]
        internal Context(C src)
        {
            this.context = src;
        }

        C IContextual<C>.Context => context;
    }
}