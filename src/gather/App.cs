//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class App
    {
        IEnvPaths Paths;

        public App()
        {
            Paths = EnvPaths.create();
        }

        void Run()
        {
            using var context = new PartContext(PartId.Universe);

            root.iteri(context.Assemblies,
                (i,a) => term.inform(string.Format("{0:D3}: Context Assembly {1} loaded from {2}", i, a.GetSimpleName(), FS.path(a.Location).ToUri())));

        }


        public static void Main(params string[] args)
        {
            var app = new App();
            app.Run();
        }
    }

    partial class XTend
    {

    }
}