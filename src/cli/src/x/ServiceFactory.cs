//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XSvc
    {
        public static ImageDataEmitter ImageDataEmitter(this IWfShell wf)
            => Z0.ImageDataEmitter.create(wf);

        public static CliWfCmdHost CliCmd(this IWfShell wf)
            => CliWfCmdHost.create(wf);

        public static MsilPipe MsilPipe(this IWfShell wf)
            => Z0.MsilPipe.create(wf);

        public static FieldLiteralEmitter FieldLiteralEmitter(this IWfShell wf)
            => Z0.FieldLiteralEmitter.create(wf);

        public static CliTables CliTables(this IWfShell wf)
            => Z0.CliTables.create(wf);

    }
}