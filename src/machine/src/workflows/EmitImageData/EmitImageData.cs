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
    using System.IO;

    using static Konst;
    using static EmitImageDataStep;

    using static z;

    public ref struct EmitImageData
    {
        readonly IWfShell Wf;

        readonly Span<IPart> Parts;

        readonly LocatedImages Images;

        readonly FolderPath TargetDir;

        public Span<LocatedPart> Index;

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from a specified <see cref='ProcessModule'/>
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
        public EmitImageData(IWfShell wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Parts = parts;
            Index = default;
            TargetDir = wf.ResourceRoot + FolderName.Define("images");
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(from).OrderBy(x => x.BaseAddress);
            Wf.Created(StepId);
        }

        public void Dispose()
        {
             Wf.Disposed(StepId);
        }

        static MemoryAddress BaseAddress(IPart src)
        {
            var match =  Path.GetFileNameWithoutExtension(src.Owner.Location);
            var module = SystemProcess.modules().Where(m => Path.GetFileNameWithoutExtension(m.Path.Name) == match).First();
            return module.Base;
        }

        public void Run()
        {
             Wf.Running(StepId);

             Index = span<LocatedPart>(Parts.Length);
             for(var i=0u; i< Parts.Length; i++)
             {
                ref readonly var part = ref skip(Parts, i);
                var @base = BaseAddress(part);
                var dstpath = TargetDir + FileName.define(part.Format(), FileExtension.Define("csv"));
                using var step = new EmitPeImage(Wf, new EmitPeImageHost(), part, @base, dstpath);
                step.Run();

                seek(Index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));
             }

            using var summarize = new EmitImageSummaries(Wf, Images, Wf.Ct);
            summarize.Run();

            Wf.Ran(StepId);
        }
    }
}