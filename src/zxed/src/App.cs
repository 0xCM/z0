//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    class App : AppShell<App,IAppContext>
    {
        public readonly PartId Part = PartId.ZXed;

        public CorrelationToken Ct {get;}

        public App()
            : base(Flow.app())
        {
            Ct = correlate(Part);
        }

        void Parse(FilePath src)
        {
            var data = XedSourceParser.Service.LoadSource(src);
            if(data.IsNonEmpty)
                term.print($"Parsed {data.Rows.Length} rows from {src}");
            else
                term.warn($"No content was parsed from {src}");
        }

        public override void RunShell(params string[] args)
        {
            var s = AB.settings(Context, Ct);
            var config = WfBuilder.configure(Context, args);
            using var log = AB.log(config);
            using var context = WfBuilder.context(Context, config, log, Ct);
            using var wf = new XedEtl(context, new XedEtlConfig(Context, s));
            wf.Run();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}