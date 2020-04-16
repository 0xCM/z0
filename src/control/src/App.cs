//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    class App : ApiShell<App,IApiContext>
    {
        static IApiContext CreateContext()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("src/control");
            var src = dir + FileName.Define("config.json");        
            var parts = PartSelection.Selected;
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(src);
            return ApiContext.Create(resolved, random, settings);
        }
        
        public App()
            : base(CreateContext())
        {
            
        }

        bool Verbose => false;

        public override void RunShell(params string[] args)
        {
            if(Verbose)
            {
                term.print("I assemble parts:");
                iter(Context.Parts, part => term.print(part));

                term.print("I know parts:");
                iter(Part.known(), part => term.print(part));

                term.print("I am configured with:");
                iter(Context.Settings, setting => term.print(setting));
            }
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}