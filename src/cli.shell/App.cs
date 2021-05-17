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
    using static CliRows;
    using K = CliTableKinds;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.CliShell, PartId.Cli, PartId.Part, PartId.Cpu);


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

        public void CollectSystemStrings(PartId part)
        {
            Reader(part, out var reader);
            var strings = reader.ReadStrings(CliStringKind.System);
            var count = strings.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(strings,i);
                Wf.Row(string.Format("{0:D5}:{1}", i, s));
            }
        }

        CliReader Reader(Assembly src)
            => Cli.reader(src);

        bool Reader(PartId part, out CliReader dst)
        {
            if(Wf.ApiCatalog.FindComponent(part, out var component))
            {
                dst = Reader(component);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        ReadOnlySpan<Assembly> ApiComponents
            => Wf.ApiCatalog.Components;

        void ReadMethodDefs()
        {
            var components = ApiComponents;
            var count = components.Length;
            var dst = Db.TableDir("cli") + FS.file(Tables.identify<MethodDefRow>().Format(), FS.Csv);
            var flow = Wf.EmittingTable<MethodDefRow>(dst);
            var writer = dst.Writer();
            var counter = 0u;
            var formatter = Tables.formatter<MethodDefRow>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var component = ref skip(components,i);
                var source = Cli.source(component);
                var provider = MethodDefProvider.create();
                var rows = provider.Load(source.TableSouce<MethodDefRow>());
                counter += Tables.emit(rows,writer);
            }
            Wf.EmittedTable(flow,counter);
        }


        protected override void Run()
        {
            var flow = Wf.Running();
            ReadMethodDefs();
            Wf.Ran(flow);
        }
    }
}