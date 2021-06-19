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
            => run(args, PartId.CliShell, PartId.Cli, PartId.Part, PartId.Cpu, PartId.AsmCore);

        public App()
        {

        }

        unsafe void ReadHeap(PartId part)
        {
            var component = Reader(part, out var reader);
            var heap = reader.SystemStringHeap();
            var data = heap.Data;
            var size = heap.Size;
            var count = CliHeaps.count(heap);
            var terminators = alloc<uint>(count);
            var found = CliHeaps.terminators(heap, terminators);
            var @base = heap.BaseAddress;

            Wf.Row(string.Format("Source:{0}", FS.path(component.Location).ToUri()));
            Wf.Row(string.Format("HeapKind:{0}", "SytemString"));
            Wf.Row(string.Format("BaseAddress:{0}", @base));
            Wf.Row(string.Format("HeapSize:{0}", size));
            Wf.Row(string.Format("EntryCount:{0}",count));
            Wf.Row(string.Format("TermCount:{0}",found));
            // var pos = 0u;
            // var address = @base;
            // for(var i=0; i<found; i++)
            // {
            //     ref readonly var end = ref skip(terminators, i);
            //     var length = end - pos;
            //     var current = slice(data, pos, length);
            //     var s = TextTools.format(recover<char>(current));
            //     pos += length;
            //     Wf.Row(string.Format("{0}:{1}", address, s));
            //     address += end;
            // }

        }

        void ReadHeaps()
        {
            var parts = Wf.ApiCatalog.PartIdentities;
            iter(parts,ReadHeap);
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

        Assembly Reader(PartId part, out CliReader dst)
        {
            if(Wf.ApiCatalog.FindComponent(part, out var component))
            {
                dst = Reader(component);
                return component;
            }
            else
                throw new Exception(string.Format("Component for {0} not found", part.Format()));
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
            ReadHeaps();
            //ReadState(Parts.Math.Assembly);
            //ReadMethodDefs();
            Wf.Ran(flow);
        }
    }
}