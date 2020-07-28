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
    using static z;

    public readonly ref struct EmitDataFiles
    {    
        public readonly EmissionDataType DataType;

        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;

        readonly LocatedImages Images;
        
        readonly FilePath PartSummaryPath;

        readonly FilePath ImageSummaryPath;

        [MethodImpl(Inline)]
        public EmitDataFiles(IWfPartEmission wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            DataType = EmissionDataType.PartDat;
            Wf.PartDatDir.Clear();
            DataType.Emitting(Wf);
            PartSummaryPath = wf.BuildStage + FileName.Define("dat.summary", FileExtensions.Csv);
            ImageSummaryPath = wf.BuildStage + FileName.Define("images.summary", FileExtensions.Csv);
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(LocatedImage.from).OrderBy(x => x.BaseAddress);
        }

        FilePath TargetPath(IPart part)
            => Wf.PartDatDir + FileName.Define(part.Format(), FileExtension.Define("csv"));

        public static void Summarize(LocatedImages src, FilePath dst)
        {
            var count = src.Count;
            var images = src.View;
            var header = text.concat(
                "Name".PadRight(60), SpacePipe, 
                "EntryAddress".PadRight(16), SpacePipe, 
                "BaseAddress".PadRight(16), SpacePipe, 
                "EndAddress".PadRight(16), SpacePipe, 
                "Size".PadRight(20), SpacePipe,
                "Gap"
                );            

            var rows = text.build();
            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref z.skip(images, i);
                rows.Append(image.Name.PadRight(60));
                rows.Append(SpacePipe);
                rows.Append(image.EntryAddress.Format().PadRight(16));
                rows.Append(SpacePipe);
                rows.Append(image.BaseAddress.Format().PadRight(16));
                rows.Append(SpacePipe);
                rows.Append(image.EndAddress.Format().PadRight(16));
                rows.Append(SpacePipe);
                rows.Append(image.Size.ToString("#,#").PadRight(20));                
                dst.Append(SpacePipe);

                if(i == 0)
                    rows.Append(0.ToString());
                else
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    rows.Append(gap.ToString("#,#"));
                }

                rows.Append(Eol); 
            }

            using var writer = dst.Writer();
            writer.Write(rows.ToString());
        }
        
        void Summarize(Span<LocatedPart> src)        
        {
            var dst = text.build();
            var ordered = src.ToEnumerable().OrderBy(x  => x.StartAddress).Array();
            var count = ordered.Length;
            var header = text.concat(
                "Part".PadRight(20), SpacePipe, 
                "StartAddress".PadRight(16), SpacePipe, 
                "EndAddress".PadRight(16), SpacePipe, 
                "Size".PadRight(12), SpacePipe,
                "Gap".PadRight(8)
                );            
            dst.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var part = ref ordered[i];
                dst.Append(part.Id.Format().PadRight(20));
                dst.Append(SpacePipe);
                dst.Append(part.StartAddress.Format().PadRight(16));
                dst.Append(SpacePipe);
                dst.Append(part.EndAddress.Format().PadRight(16));
                dst.Append(SpacePipe);
                dst.Append(part.Segment.Length.ToString("#,#").PadRight(12));
                dst.Append(SpacePipe);

                if(i == 0)
                    dst.Append(0.ToString());
                else
                {
                    ref readonly var prior = ref ordered[i - 1];
                    var gap = (ulong)(part.StartAddress - prior.EndAddress);
                    dst.Append(gap.ToString("#,#"));
                }

                dst.Append(Eol); 

            }

            using var writer = PartSummaryPath.Writer();
            writer.Write(dst.ToString());
        }
        
        public void Run()
        {  
             var index = z.span<LocatedPart>(Parts.Length);
             var source = z.span(Parts);
             for(var i=0u; i< Parts.Length; i++)
             {
                ref readonly var part = ref z.skip(source,i);
                var @base = part.BaseAddress();                 
                using var step = new EmitHexLineFile(Wf, part, @base, TargetPath(part));
                step.Run();

                z.seek(index,i) = new LocatedPart(part, @base, step.OffsetAddress);

             }
            
            Summarize(index);
            Summarize(Images, ImageSummaryPath);
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);                          
        }
    }
}