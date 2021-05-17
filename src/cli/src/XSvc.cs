//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static PdbServices;

    using Svc = Z0;

    [ApiHost]
    public static partial class XSvc
    {
        [Op]
        public static CliPipe CliPipe(this IWfRuntime wf)
            => Svc.CliPipe.create(wf);

        [Op]
        public static MsilPipe MsilPipe(this IWfRuntime wf)
            => Svc.MsilPipe.create(wf);

        [Op]
        public static ImageCsvReader ImageCsvReader(this IWfRuntime wf)
            => Svc.ImageCsvReader.create(wf);

        [Op]
        public static AppModules AppModules(this IWfRuntime wf)
            => Svc.AppModules.create(wf);

        [Op]
        public static PdbSymbolStore PdbSymbolStore(this IWfRuntime wf)
            => Cli.symbols(wf);

        [Op]
        public static PdbReader PdbReader(this IWfRuntime wf, in SymbolSource src)
            => Svc.PdbServices.reader(wf,src);

        [Op]
        public static ProcessContextPipe ProcessContextPipe(this IWfRuntime wf)
            => Svc.ProcessContextPipe.create(wf);

        [Op]
        public static RegionProcessor RegionProcessor(this IWfRuntime wf)
            => Svc.RegionProcessor.create(wf);
    }
}