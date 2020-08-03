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
    using static z;
    
    
    public readonly ref struct EmitImageContent
    {    
        public readonly EmissionDataType DataType;

        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        readonly LocatedImages Images;
        
        readonly FolderPath TargetDir;
        
        readonly FilePath PartSummaryPath;

        readonly FilePath ImageSummaryPath;

        [MethodImpl(Inline)]
        public EmitImageContent(WfContext wf, IPart[] parts, CorrelationToken? ct = null)
        {
            Wf = wf;
            Ct = correlate(ct);
            Parts = parts;
            DataType = EmissionDataType.PartDat;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("images");
            PartSummaryPath = Wf.IndexRoot + FileName.Define("machine.images.parts", FileExtensions.Csv);
            ImageSummaryPath = Wf.IndexRoot + FileName.Define("machine.images", FileExtensions.Csv);
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(image).OrderBy(x => x.BaseAddress);
            Wf.Created(nameof(EmitImageContent), Ct);
        }

        public static LocatedImage image(ProcessModule src)
        {
            var path = FilePath.Define(src.FileName);
            var part = TableEmission.part(path);
            var entry = (MemoryAddress)src.EntryPointAddress;
            var @base = src.BaseAddress;
            var size = (uint)src.ModuleMemorySize;
            return new LocatedImage(path, part, entry, @base, size);
        }

        FilePath TargetPath(IPart part)
            => TargetDir + FileName.Define(part.Format(), FileExtension.Define("csv"));
            

        public static void Summarize(LocatedImages src, FilePath dst)
        {            
            var system = zdat.SystemImages;
            var count = src.Count;
            var images = src.View;
            var fields = TableEmission.fields<LocatedImageField>();
            var header = TableEmission.header(fields);
            var summaries = span<ProcessImageSummary>(count);

            var rows = text.build();
            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);

                var name = image.Name;
                var match = system.First((in SystemImageSymbol r) => r.Name == name);
                var symbolic = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);

                summary.ImageId = symbolic;
                summary.PartId = image.PartId;
                summary.EntryAddress = image.EndAddress;
                summary.BaseAddress = image.BaseAddress;
                summary.EndAddress = image.EndAddress;
                summary.Size = image.Size;

                rows.Append(symbolic.PadRight(fields[0].Width));
                rows.Append(SpacePipe);
                rows.Append(image.PartId == 0 ? EmptyString.PadRight(fields[1].Width) : image.PartId.Format().PadRight(fields[1].Width));
                rows.Append(SpacePipe);
                rows.Append(image.EntryAddress.Format().PadRight(fields[2].Width));
                rows.Append(SpacePipe);
                rows.Append(image.BaseAddress.Format().PadRight(fields[3].Width));
                rows.Append(SpacePipe);
                rows.Append(image.EndAddress.Format().PadRight(fields[4].Width));
                rows.Append(SpacePipe);
                rows.Append(image.Size.Format().PadRight(fields[5].Width));                
                rows.Append(SpacePipe);

                if(i == 0)
                    rows.Append(0.ToString());
                else
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                    rows.Append(gap.ToString("#,#"));
                }

                rows.Append(Eol); 
            }

            using var writer = dst.Writer();
            writer.Write(rows.ToString());
        }
                
        public void Run()
        {  
             var index = z.span<LocatedPart>(Parts.Length);
             var source = z.span(Parts);
             for(var i=0u; i< Parts.Length; i++)
             {
                ref readonly var part = ref z.skip(source, i);
                var @base = part.BaseAddress();                 
                using var step = new EmitHexLineFile(Wf, part, @base, TargetPath(part), Ct);
                step.Run();

                z.seek(index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));

             }
            
            Summarize(Images, ImageSummaryPath);
        }

        public void Dispose()
        {
             Wf.Finished(nameof(EmitImageContent), Ct);
        }
    }
}