//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        Machine(IMachineContext context)
        {
            Context = context;
        }

        public void Run()
        {
            Describe();

        }

        void Describe()
        {
            Control.iter(Context.CodeFiles, file => term.print($"{file.Left}: {file.Right}"));
        }
        
        public void Dispose()
        {

        }

        public static void Run(IMachineContext context)
        {
            try
            {            
                using var machine = new Machine(context); 
                machine.Run();   
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

}