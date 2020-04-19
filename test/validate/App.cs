//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Parts;

    class App : Shell<App>
    { 
        public override void RunShell(params string[] args)
            => PartRunner.RunParts(args);

        public static void Main(params string[] args) 
            => Launch(args); 
        
        protected override void OnDispose()
        {
            term.inform("Finished part execution");

        }
    } 
}