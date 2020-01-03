//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;    

    public abstract class ConsoleApp<A> : Context<A>
        where A : ConsoleApp<A>, new()
    {
        protected ConsoleApp(IPolyrand random)
            : base(random)
        {


        }

        protected abstract void OnExecute(params string[] args);

        protected virtual void RunApp(params string[] args)
        {
            try
            {            
                OnExecute(args);

            }
            catch (Exception e)
            {
                NotifyError(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunApp();
    }
}