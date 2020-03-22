//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static Root;

    public abstract class ConsoleApp<A> : IConsoleApp<A>, IAppMsgSink
        where A : ConsoleApp<A>, new()
    {        
        IAppContext Context {get;}

        readonly IAppMsgQueue MsgQueue;
                
        protected ConsoleApp(IComposedApiContext context, IAppMsgQueue queue)
        {
            this.Context = context;
            this.MsgQueue = queue;
            this.Resolved = context.Compostion.Resolved;

        }

        protected ConsoleApp(IComposedApiContext context)
            : this(context, AppMsgQueue.Create())
        {


        }

        protected abstract void Execute(params string[] args);

        public virtual IApiAssembly[] Resolved {get;}

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

        public void Notify(AppMsg msg)
            => MsgQueue.Accept(msg);
    }

    public abstract class ConsoleApp<A,C> :  ConsoleApp<A>, IConsoleApp<A,C>
        where A : ConsoleApp<A,C>, new()
        where C : IComposedApiContext
    {
        public C Context {get;}

        protected ConsoleApp(C context)
            : base(context)
        {
            Context = context;
        }
    }
}