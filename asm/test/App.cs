//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    class App : TestApp<App>
    {            
        //bool CustomEnabled = true;

        // protected override bool RunExplicit()
        // {
        //     if(CustomEnabled)
        //     {
        //         using(var check = new t_asm_archiver())
        //             RunAction(check, () => check.RunExplicit());
        //         return false;
        //     }
        //     else
        //         return true;
        // }
        
        public static void Main(params string[] args)
        {
            Run(args);
        }
    }

}