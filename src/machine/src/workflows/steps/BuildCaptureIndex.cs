//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class BuildCaptureIndex : WfHost<BuildCaptureIndex>
    {
        public static void EmitAsmTables(IWfShell wf, IWfCaptureState state, in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new ProcessAsm(state, encoded);
                var result = processor.Process();

                wf.Processed(delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                    process(wf, skip(sets,i));
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        public static void process(IWfShell wf, in AsmRowSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);
            var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());

            var formatter = Formatters.dataset<AsmRowField>();
            var header = Table.header53<AsmRowField>();
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRow.format(skip(records,i), formatter).Render());

            wf.EmittedTable<AsmRow>(count, dst);
        }

        public static Span<ApiPartRoutines> DecodeParts(IWfShell wf, IAsmDecoder decoder, in ApiCodeBlockIndex src)
        {
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
            var kMembers = 0u;
            var kHosts = 0u;
            var kParts = 0u;
            var kFx = 0u;

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = src.Hosts.Where(h => h.Owner == part);
                    var hostCount = hosts.Length;


                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        var members = src[host];
                        var fx = CaptureIndexBuilder.DecodeBlocks(decoder, members);
                        hostFx.Add(fx);
                        kHosts++;
                        kMembers += fx.RoutineCount;
                        kFx += fx.InstructionCount;
                    }

                    wf.Status(text.format(WfProgress.DecodedPart, hostFx.Count, part.Format()));
                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

                    kParts++;
                    wf.Status(text.format(WfProgress.DecodingMachine, kParts, kHosts, kMembers, kFx));
                }
            }

            wf.Status(text.format(WfProgress.DecodedMachine, src.EntryCount, src.Parts.Length));
            return dst;
        }

        public static void process(IWfShell wf, ReadOnlySpan<ApiPartRoutines> src)
        {
            try
            {
                var count = src.Length;
                for(var i=0; i<count; i++)
                    process(wf, skip(src,i));

            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        static void process(IWfShell wf, in ApiPartRoutines src)
            => ProcessInstructions.create().Run(wf, src);

    }

    // ref struct BuildCaptureIndexStep
    // {
    //     readonly IWfShell Wf;

    //     public ApiCodeBlockIndex Target;

    //     readonly IWfCaptureState State;

    //     readonly WfHost Host;

    //     public BuildCaptureIndexStep(IWfShell wf, WfHost host, IWfCaptureState state)
    //     {
    //         Host = host;
    //         Wf = wf.WithHost(Host);
    //         State = state;
    //         Target = default;
    //         Wf.Created();
    //     }

    //     public void Dispose()
    //     {
    //         Wf.Disposed();
    //     }

    //     void BuildIndex()
    //     {
    //         using var builder = new ApiIndexBuilder(Wf, Host);
    //         builder.Run();
    //         Target = builder.Product;
    //         Wf.Raise(new PartIndexCreated(Host, Target, Wf.Ct));
    //     }

    //     public void Run()
    //     {
    //         Wf.Running();

    //         try
    //         {
    //             BuildIndex();
    //             Process(Target);
    //             Process(DecodeParts(Target));

    //         }
    //         catch(Exception e)
    //         {
    //             Wf.Error(e);
    //         }

    //         Wf.Ran();
    //     }

    //     Span<ApiPartRoutines> DecodeParts(in ApiCodeBlockIndex src)
    //     {
    //         var parts = src.Parts;
    //         var partCount = parts.Length;
    //         var dst = alloc<ApiPartRoutines>(partCount);
    //         var hostFx = list<ApiHostRoutines>();
    //         var kMembers = 0u;
    //         var kHosts = 0u;
    //         var kParts = 0u;
    //         var kFx = 0u;

    //         for(var i=0; i<partCount; i++)
    //         {
    //             hostFx.Clear();
    //             var part = parts[i];
    //             if(part == 0)
    //                 dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
    //             else
    //             {
    //                 var hosts = src.Hosts.Where(h => h.Owner == part);
    //                 var hostCount = hosts.Length;

    //                 Wf.Status(text.format("Decoding {0}", part.Format()));

    //                 for(var j=0; j<hostCount; j++)
    //                 {
    //                     var host = hosts[j];
    //                     var members = src[host];
    //                     var fx = CaptureIndexBuilder.DecodeBlocks(State.RoutineDecoder, members);
    //                     hostFx.Add(fx);
    //                     kHosts++;
    //                     kMembers += fx.RoutineCount;
    //                     kFx += fx.InstructionCount;
    //                 }

    //                 dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

    //                 kParts++;
    //                 Wf.Status(text.format(RP.PSx4, kParts, kHosts, kMembers, kFx));
    //             }
    //         }

    //         Wf.Status(text.format("Decoded {0} entries from {1} parts", src.EntryCount, src.Parts.Length));
    //         return dst;
    //     }

    //     void Process(in ApiCodeBlockIndex encoded)
    //     {
    //         try
    //         {
    //             var processor = new ProcessAsm(State, encoded);
    //             var result = processor.Process();

    //             Wf.Processed(delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

    //             var sets = result.View;
    //             var count = result.Count;
    //             for(var i=0; i<count; i++)
    //                 Process(skip(sets,i));
    //         }
    //         catch(Exception e)
    //         {
    //             Wf.Error(e);
    //         }
    //     }

    //     void Process(in AsmRowSet<Mnemonic> src)
    //     {
    //         var count = src.Count;
    //         var records = span(src.Sequenced);
    //         var dst = Wf.Db().Table(AsmRow.TableId, src.Key.ToString());

    //         var formatter = Formatters.dataset<AsmRowField>();
    //         using var writer = dst.Writer();
    //         writer.WriteLine(formatter.HeaderText);
    //         for(var i=0; i<count; i++)
    //             writer.WriteLine(AsmRow.format(skip(records,i), formatter).Render());

    //         Wf.EmittedTable<AsmRow>(count, dst);
    //     }

    //     void Process(ReadOnlySpan<ApiPartRoutines> src)
    //     {
    //         try
    //         {
    //             var count = src.Length;
    //             for(var i=0; i<count; i++)
    //                 Process(skip(src,i));

    //         }
    //         catch(Exception e)
    //         {
    //             Wf.Error(e);
    //         }
    //     }

    //     void Process(in ApiPartRoutines src)
    //         => ProcessInstructions.create().Run(Wf, src);

    // }
}