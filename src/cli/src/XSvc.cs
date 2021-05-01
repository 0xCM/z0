//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static partial class XSvc
    {
        [Op]
        public static ImageMetaPipe ImageMetaPipe(this IWfRuntime wf)
            => Z0.ImageMetaPipe.create(wf);

        [Op]
        public static MsilPipe MsilPipe(this IWfRuntime wf)
            => Z0.MsilPipe.create(wf);

        [Op]
        public static ImageCsvReader ImageCsvReader(this IWfRuntime wf)
            => Z0.ImageCsvReader.create(wf);

        [Op]
        public static AppModules AppModules(this IWfRuntime wf)
            => Z0.AppModules.create(wf);

        [Op]
        public static PdbSymbolStore PdbSymbolStore(this IWfRuntime wf)
            => Cli.symbols(wf);

    }
}