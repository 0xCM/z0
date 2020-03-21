//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static Root;

    public abstract class ConsoleApp<A> : IConsoleApp<A>
        where A : ConsoleApp<A>, new()
    {        
        readonly IContext Context;

        readonly IAppMsgQueue MsgQueue;
                
        protected ConsoleApp(IComposedContext context)
        {
            this.Context = context;
            this.MsgQueue = AppMsgQueue.Create();
            this.Resolved = context.Compostion.Resolved;
        }

        protected abstract void Execute(params string[] args);

        public virtual IAssemblyResolution[] Resolved {get;}

        public void RunApp(params string[] args)
        {
            try
            {            
                Execute(args);
            }
            catch (Exception e)
            {
                iter(MsgQueue.Flush(e), term.print);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunApp();

        public string Format()
            => GetType().Name;
    }

    public abstract class ConsoleApp<A,C> :  ConsoleApp<A>, IConsoleApp<A,C>
        where A : ConsoleApp<A,C>, new()
        where C : IComposedContext
    {
        public C Context {get;}

        protected ConsoleApp(C context)
            : base(context)
        {
            Context = context;
        }
    }
}