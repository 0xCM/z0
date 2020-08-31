//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitImageSummariesStep;

    using static z;

    public ref struct EmitImageSummaries
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        public WfStepId Id;

        readonly LocatedImages Images;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitImageSummaries(IWfContext wf, LocatedImages images, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Id = AB.step(typeof(EmitImageSummaries));
            Images = images;
            TargetPath = Wf.IndexRoot + FileName.define("machine.images", FileExtensions.Csv);
            Wf.Created(StepId);
        }

        public void Run()
        {
            Summarize(Images, TargetPath);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        static void Summarize(LocatedImages src, FilePath dst)
        {
            var system = Imaging.SystemImages;
            var count = src.Count;
            var images = src.View;
            var fields = Table.columns<LocatedImageField>();
            var header = Table.header(fields);
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
    }
}