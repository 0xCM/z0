//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.CliShell, PartId.Cli, PartId.Part);


        public App()
        {

        }


        void Test4()
        {
            Size<byte> a = 31;
            var b = a.Align(4);
            Wf.Row(a.Measure);
            Wf.Row(a.Untyped);
            Wf.Row(b.Measure);

            Wf.Row(string.Format("Align({0}) = {1}", a, b));
        }

        public void Test5()
        {
            ApiKeyChecks.create(Wf).Run();
        }

        public void Test6(PartId part)
        {
            Reader(part, out var reader);
            var strings = reader.ReadSystemStrings();
            var count = strings.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(strings,i);
                Wf.Row(string.Format("{0:D5}:{1}", i, s));
            }
        }

        bool Reader(PartId part, out CliReader dst)
        {
            if(Wf.ApiCatalog.FindComponent(part, out var component))
            {
                dst = Cli.reader(component);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }


        protected override void Run()
        {
            var flow = Wf.Running();

            Wf.Ran(flow);
        }
    }
}