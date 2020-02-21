//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;    


    public interface IConsoleApp : IAssemblyComposition, IContext
    {
        void RunApp(params string[] args);   
             
    }

    public abstract class ConsoleApp<A> : Context<A>, IConsoleApp
        where A : ConsoleApp<A>, new()
    {
        protected ConsoleApp(IPolyrand random)
            : base(random)
        {            

        }

        protected abstract void Execute(params string[] args);

        public abstract IAssemblyDesignator[] Resolved {get;}

        public void RunApp(params string[] args)
        {
            try
            {            
                Execute(args);

            }
            catch (Exception e)
            {
                PostError(e);
            }
        }

        protected static void Run(params string[] args)
            => new A().RunApp();
    }
}