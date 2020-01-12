//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    class App : TestApp<App>
    {            
        bool CustomEnabled = false;

        protected override void RunCustom()
        {
            if(CustomEnabled)
            {
                using(var check = new t_asm_checks())
                {
                    RunAction(check, () => check.RunExplicit());
                }
            }

        }
        
        public static void Main(params string[] args)
        {
            Run(args);
        }
    }

}