//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public abstract class Shell<A,C> : IShell
        where A : Shell<A,C>, new()
        where C : IContext
    {
        public C Context {get;}

        protected Shell(C context)
        {
            Context = context;
        }

        public virtual void Run(params string[] args)
        {
            try   
            {
                 Execute(args); 
            }
            catch (Exception e) 
            { 
                OnFatalError(e); 
            }
        }

        protected virtual void OnFatalError(Exception e)
            => Console.Error.WriteLine(e);

        protected abstract void Execute(params string[] args);

        protected static void Launch(params string[] args)
            => new A().Run();
    }

    public abstract class Shell<A> : Shell<A, IContext>
        where A : Shell<A>, new()
    {

        protected Shell()
            : base(IContext.Default)
        {

        }

        protected Shell(IContext context)
            : base(context)
        {

        }
    }
         
}