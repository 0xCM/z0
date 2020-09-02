//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    using static Konst;
    using static z;

    class Shell : AppShell<Shell,IAppContext>
    {
        public CorrelationToken Ct {get;}

        public WfConfig Config {get;}

        public Shell()
            : base(WfBuilder.app())
        {
            Config = WfBuilder.configure(Context);
            Ct = correlate(PartId.ZXed);
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
            var config = WfBuilder.configure(Context, args);
            using var log = AB.log(config);
            using var wf = WfBuilder.shell(config, log);
            using var step = new XedWf(wf, new XedEtlConfig(Context, config.Settings));
            step.Run();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}