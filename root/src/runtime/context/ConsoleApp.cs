//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
        
    public abstract class ConsoleApp<A> : IConsoleApp<A>
        where A : ConsoleApp<A>, new()
    {        
        readonly IContext Context;

        readonly IAppMsgLog MsgLog;

        readonly IAppMsgQueue MsgQueue;
        
        
        protected ConsoleApp(IContext context, IAppMsgLog log)
        {
            this.Context = context;
            this.MsgQueue = MsgContextQueue.Create(context);
            this.MsgLog = log;
        }

        protected abstract void Execute(params string[] args);

        public abstract IAssemblyResolution[] Resolved {get;}

        public void RunApp(params string[] args)
        {
            try
            {            
                Execute(args);
            }
            catch (Exception e)
            {
                MsgQueue.Flush(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunApp();

        public string Format()
            => GetType().Name;
    }

    public abstract class ConsoleApp<A,C> :  ConsoleApp<A>, IConsoleApp<A,C>
        where A : ConsoleApp<A,C>, new()
        where C : IContext
    {
        public C Context {get;}

        protected ConsoleApp(C context, IAppMsgLog log)
            : base(context, log)
        {

        }

    }

}