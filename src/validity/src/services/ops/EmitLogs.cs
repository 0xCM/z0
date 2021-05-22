//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;

    partial class TestApp<A>
    {
        /// <summary>
        /// Defines enum-predicated header content
        /// </summary>
        readonly struct DatasetHeader<F>
            where F : unmanaged, Enum
        {
            public F[] Fields
            {
                get => Enums.literals<F>();
            }

            public string[] Labels
            {
                get => Fields.Map(f => f.ToString());
            }
        }

        public void EmitLogs()
        {
            var basename = AppName;
            var results = SortResults();

            if(results.Any())
            {
                var timing = results.Sum(x => x.Duration.TimeSpan.TotalSeconds);
                var dst = Db.CaseLogSummary();
                Wf.Status($"Emitting case log to {dst.ToUri()} with execution time of {timing} seconds");
                EmitTestCaseLog(dst, results);
            }
        }

        static string render<F>(DatasetHeader<F> src, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var service = formatter<F>(delimiter);
            var cols = src.Fields;
            var labels = src.Labels;
            for(var i=0; i<cols.Length; i++)
            {
                if(i==0)
                    service.Append(cols[i], labels[i]);
                else
                    service.Delimit(cols[i], labels[i]);
            }
            return service.Render();
        }

        static DatasetFormatter<F> formatter<F>(char delimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        static string header53<T>(char delimiter = FieldDelimiter)
            where T : unmanaged, Enum
                => render(datasetHeader<T>(),delimiter);

        static DatasetHeader<F> datasetHeader<F>()
            where F : unmanaged, Enum
                => new DatasetHeader<F>();

        static FS.FilePath EmitTestCaseLog(FS.FilePath dst, TestCaseRecord[] records)
        {
            if(records.Length == 0)
                return FS.FilePath.Empty;

            Emit(records, dst, default(TestCaseField));
            return dst;
        }

        static void Emit<R,F>(R[] records, FS.FilePath dst, F f = default, char delimiter = FieldDelimiter)
            where R : struct, ITextual
            where F : unmanaged, Enum
        {
            if(records.Length == 0)
                return;

            using var writer = dst.Writer();
            writer.WriteLine(header53<F>(delimiter));
            var formatter = formatter<F>(delimiter);
            root.iter(records, r => writer.WriteLine(r.Format()));
        }
    }
}