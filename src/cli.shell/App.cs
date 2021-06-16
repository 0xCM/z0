//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

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
            => CliReader.read(src);

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

        unsafe void ReadState(Assembly src)
        {
            var state = Cli.state(src);
            var header = state.MetadataHeader;
            Wf.Row(string.Format("{0,-16} | {1}", "Version", header.Format()));
            Wf.Row(string.Format("{0,-16} | {1}", "StreamKind", state.StreamKind));
            Wf.Row(string.Format("{0,-16} | [{1}]",  "Tables", state.SortedTables));
            var kinds = Cli.TableKinds();
            var counts = state.TableRowCounts;
            var count = kinds.Length;
            for(byte i=0; i<count; i++)
            {
                var rowcount = counts[i];
                if(rowcount != 0)
                {
                    var kind = (CliTableKind)i;
                    var block = state.TableBlocks[kind];
                    Wf.Row(string.Format("{0:x2} {1,-32}: {2,-8} {3}", i, kind, rowcount, block.BaseAddress));
                }
            }

            for(var i=0; i<state.StreamHeaders.Count; i++)
            {
                ref readonly var sheader = ref state.StreamHeaders[i];
                Wf.Row(string.Format("{0,-16} | {1,-8} | {2}", sheader.Name, sheader.Offset, sheader.Size));
            }

            Wf.Row(string.Format("{0,-16} | {1}", "StringHeap", state.StringHeap.BaseAddress));
            Wf.Row(string.Format("{0,-16} | {1}", "BlobHeap", state.BlobHeap.BaseAddress));
            Wf.Row(string.Format("{0,-16} | {1}", "GuidHeap", state.GuidHeap.BaseAddress));
            Wf.Row(string.Format("{0,-16} | {1}", "UserStringHeap", state.UserStringHeap.BaseAddress));

            state.StringHeap.ReadHandles();
            root.iter(state.StringHeap.ReadHandles(), h => Wf.Row(state.StringHeap.GetString(h)));

        }

        // void ReadMethodDefs()
        // {
        //     var components = ApiComponents;
        //     var count = components.Length;
        //     var dst = Db.TableDir("cli") + FS.file(Tables.identify<MethodDefRow>().Format(), FS.Csv);
        //     var flow = Wf.EmittingTable<MethodDefRow>(dst);
        //     var writer = dst.Writer();
        //     var counter = 0u;
        //     var formatter = Tables.formatter<MethodDefRow>();
        //     writer.WriteLine(formatter.FormatHeader());
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var component = ref skip(components,i);
        //         var source = Cli.source(component);
        //         var provider = MethodDefProvider.create();
        //         var rows = provider.Load(source.TableSouce<MethodDefRow>());
        //         counter += Tables.emit(rows,writer);
        //     }
        //     Wf.EmittedTable(flow,counter);
        // }


        protected override void Run()
        {
            var flow = Wf.Running();
            ReadState(Parts.Math.Assembly);
            //ReadMethodDefs();
            Wf.Ran(flow);
        }
    }
}