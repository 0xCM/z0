//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;
    using static Typed;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Dynamic, PartId.DynamicShell, PartId.Cpu, PartId.Math, PartId.GMath, PartId.Part);

        readonly IDynexus Dynamic;

        public App()
        {
            Dynamic = Dynops.Dynexus;
        }

        void RunCalc()
        {
            //BinaryOpsDemo.runC(msg => Wf.Row(msg));
        }

        void Test1()
        {
            //BinaryOpsDemo.runB(msg => Wf.Row(msg));
        }

        void Test2()
        {
            var n = n2;
            var t = z32;
            var m = CaseMethods.BinaryAdd_Method;
            var id = m.Identify();
            var factory = Dynamic.Factory(OperatorClasses.binary(t));
            var fx = factory.Create(m);
            Wf.Row(fx(3,4).ToString());
        }


        void Test3()
        {
            //BinaryOpsDemo.runA(msg => Wf.Row(msg));
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
            var strings = reader.ReadStrings(CliStringKind.User);
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
            Test6(PartId.Cpu);
            Wf.Ran(flow);
        }
    }
}