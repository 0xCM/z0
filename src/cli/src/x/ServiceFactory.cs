//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XSvc
    {
        public static ImageDataEmitter ImageDataEmitter(this IWfRuntime wf)
            => Z0.ImageDataEmitter.create(wf);

        public static CliWfCmdHost CliCmd(this IWfRuntime wf)
            => CliWfCmdHost.create(wf);

        public static MsilPipe MsilPipe(this IWfRuntime wf)
            => Z0.MsilPipe.create(wf);

        public static FieldLiteralEmitter FieldLiteralEmitter(this IWfRuntime wf)
            => Z0.FieldLiteralEmitter.create(wf);

        public static CliTables CliTables(this IWfRuntime wf)
            => Z0.CliTables.create(wf);

    }
}