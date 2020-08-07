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
    using static Flow;
    using static EmitImageContentStep;

    using static z;
    
    [Step(Kind)]
    public ref struct EmitImageContent
    {    
        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        readonly Span<IPart> Parts;

        readonly LocatedImages Images;
        
        readonly FolderPath TargetDir;    

        public Span<LocatedPart> Index;

        [MethodImpl(Inline)]
        public EmitImageContent(WfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            Index = default;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("images");
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(LocatedImage.from).OrderBy(x => x.BaseAddress);
            Wf.Created(Name, Ct);
        }

        public void Run()
        {  
             Wf.Running(Name, Ct);

             Index = z.span<LocatedPart>(Parts.Length);
             for(var i=0u; i< Parts.Length; i++)
             {
                ref readonly var part = ref skip(Parts, i);
                var @base = part.BaseAddress();                 
                var dstpath = TargetDir + FileName.Define(part.Format(), FileExtension.Define("csv"));
                using var step = new EmitPeImage(Wf, part, @base, dstpath, Ct);
                step.Run();
             
                seek(Index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));
             }
            
            using var summarize = new EmitImageSummaries(Wf, Images, Ct);
            summarize.Run();

            Wf.Ran(Name, Ct);
        }

        public void Dispose()
        {
             Wf.Finished(Name, Ct);
        }
    }
}