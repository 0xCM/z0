//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    /// <summary>
    /// Base class for shells with pararametric context
    /// </summary>
    /// <typeparam name="S">The shell reification type</typeparam>
    /// <typeparam name="C">The shell context type</typeparam>
    public abstract class Shell<S,C> : Shell<S>
        where S : Shell<S,C>, new()
        where C : IWfContext
    {
        public new C Context {get;}

        public virtual void RunShell(C context)
        {

        }

        protected Shell(C context)
            : base(context)
        {
            Context = context;
        }

        protected Shell(C context, IMultiSink sink)
            : base(context, sink)
        {
            Context = context;
        }
    }
}