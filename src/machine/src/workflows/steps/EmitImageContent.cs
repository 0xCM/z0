//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Diagnostics;

    using static Konst;
    using static EmitImageContentStep;

    using static z;

    public ref struct EmitImageContent
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly Span<IPart> Parts;

        readonly LocatedImages Images;

        readonly FolderPath TargetDir;

        public Span<LocatedPart> Index;

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcesModule'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage from(ProcessModule src)
        {
            var path = FilePath.Define(src.FileName);
            var part = PartIdParser.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

        [MethodImpl(Inline)]
        public EmitImageContent(IWfShell wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            Index = default;
            TargetDir = wf.ResourceRoot + FolderName.Define("images");
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(from).OrderBy(x => x.BaseAddress);
            Wf.Created(StepId);
        }

        public void Dispose()
        {
             Wf.Finished(StepId);
        }

        public void Run()
        {
             Wf.Running(StepId);

             Index = z.span<LocatedPart>(Parts.Length);
             for(var i=0u; i< Parts.Length; i++)
             {
                ref readonly var part = ref skip(Parts, i);
                var @base = part.BaseAddress();
                var dstpath = TargetDir + FileName.define(part.Format(), FileExtension.Define("csv"));
                using var step = new EmitPeImage(Wf, part, @base, dstpath, Ct);
                step.Run();

                seek(Index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));
             }

            using var summarize = new EmitImageSummaries(Wf, Images, Ct);
            summarize.Run();

            Wf.Ran(StepId);
        }
    }
}