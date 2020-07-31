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
    
    public readonly ref struct EmitImageContent
    {    
        public readonly EmissionDataType DataType;

        readonly IEmissionWorkflow Wf;

        readonly IPart[] Parts;

        readonly LocatedImages Images;
        
        readonly FilePath PartSummaryPath;

        readonly FilePath ImageSummaryPath;

        [MethodImpl(Inline)]
        public EmitImageContent(IEmissionWorkflow wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            DataType = EmissionDataType.PartDat;
            Wf.PartDatDir.Clear();
            DataType.Emitting(Wf);
            PartSummaryPath = wf.BuildStage + FileName.Define("machine.images.parts", FileExtensions.Csv);
            ImageSummaryPath = wf.BuildStage + FileName.Define("machine.images", FileExtensions.Csv);
            var process = Process.GetCurrentProcess();
            Images = process.Modules.Cast<ProcessModule>().Map(image).OrderBy(x => x.BaseAddress);
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
            => Wf.PartDatDir + FileName.Define(part.Format(), FileExtension.Define("csv"));
            
        public static void Summarize(LocatedImages src, FilePath dst)
        {            
            var system = zdat.SystemImages;
            var count = src.Count;
            var images = src.View;
            var fields = TableEmission.fields<LocatedImageField>();
            var header = TableEmission.header(fields);

            var rows = text.build();
            rows.AppendLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref z.skip(images, i);
                var name = image.Name;
                var match = system.First((in SystemImageSymbol r) => r.Name == name);
                var symbolic = match.IsSome() ? match.Value.Identifier : image.Name.Replace("z0.", EmptyString);

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
                ref readonly var part = ref z.skip(source,i);
                var @base = part.BaseAddress();                 
                using var step = new EmitHexLineFile(Wf, part, @base, TargetPath(part));
                step.Run();

                z.seek(index,i) = new LocatedPart(part, @base, (uint)(step.OffsetAddress - @base));

             }
            
            Summarize(Images, ImageSummaryPath);
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);                          
        }
    }

    partial class XTend
    {
        public static T? First<T>(this ReadOnlySpan<T> src, ValuePredicate<T> predicate)
            where T : struct
        {
            var count = src.Length;
            ref readonly var start = ref z.first(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var candidate = ref z.skip(start,i);
                if(predicate(candidate))
                    return candidate;
            }
            return null;
        }
    }
}