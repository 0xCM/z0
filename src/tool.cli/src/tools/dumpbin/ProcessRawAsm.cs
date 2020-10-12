//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static ProcessRawAsmStep;

    public readonly struct ProcessRawAsmStep : IWfStep<ProcessRawAsmStep>
    {
        public static WfStepId StepId
            => WfCore.step<ProcessRawAsmStep>();
    }

    partial struct DumpBin
    {
        public struct ProcessRawAsm : IToolProcessor<DumpBin,DumpBinFlag>
        {
            public const string ActorName = nameof(ProcessRawAsm);

            public IWfShell Wf {get;}

            public uint LineCount;

            public uint IxCount;

            public DumpBinFlag Flags {get;}

            public DumpBinOptions Options {get;}

            public ToolArchive<DumpBin> Archive {get;}

            [MethodImpl(Inline)]
            public ProcessRawAsm(IWfShell wf, FS.FolderPath output, FS.FolderPath processed, DumpBinFlag flags, DumpBinOptions options)
            {
                Wf = wf;
                LineCount = 0;
                IxCount = 0;
                Archive = Tools.archive<DumpBin>(output, processed);
                Flags = flags;
                Options = options;
                Wf.Created(StepId);
            }

            const byte Seg0Min = 0;

            const byte Seg0Size = (byte)RawAsmField.Address;

            const byte Seg1Size = (byte)RawAsmField.Mnemonic;

            const byte Seg1Min = Seg0Size + 2;

            const byte Seg2Min = 33;


            [MethodImpl(Inline)]
            bool Parse(string src, ref RawAsmTable dst)
            {
                var parser = HexNumericParser.Service;
                if(src.Length >= 33 && LineCount >= 5)
                {
                    dst = new RawAsmTable(
                        LineCount,
                        parser.Parse<ulong>(text.slice(src,Seg0Min, Seg0Size), 0ul),
                        text.slice(src, Seg1Min, Seg1Size),
                        text.slice(src,Seg2Min));
                    return true;
                }
                return false;
            }

            void Process(ToolEmission<DumpBin> src, FilePath dst)
            {
                LineCount = 0;
                IxCount = 0;


                using var reader = src.Target.Reader();
                using var writer = dst.Writer();
                var table = new RawAsmTable();
                writer.WriteLine(table.FormatHeader());
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Trim();
                    if(Parse(line, ref table))
                    {
                        IxCount++;
                        writer.WriteLine(table.Format());
                    }

                    LineCount++;
                }

                writer.Flush();
                writer.Dispose();
            }

            const string SearchPattern = "*.instructions.asm";

            public ListedFiles List()
                => Tools.list(Archive.Dir(SearchPattern));

            public void Process()
            {
                var files = Archive.Dir("*.instructions.asm").Table;
                var count = files.Count;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var input = ref files[i];
                }

            }

            public void Dispose()
            {
                Wf.Disposed(StepId);
            }
        }
    }
}