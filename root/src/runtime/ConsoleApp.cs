//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
        
    public abstract class ConsoleApp<A> : IConsoleApp
        where A : ConsoleApp<A>, new()
    {
        readonly IMsgContext Queue;

        readonly IAppMsgLog MsgLog;

        protected ConsoleApp(IAppMsgLog log)
        {
            this.Queue = MsgContext.Create();
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
                Queue.Flush(e,MsgLog);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunApp();
    }
}