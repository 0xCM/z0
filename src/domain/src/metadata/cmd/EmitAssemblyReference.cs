//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct ClrCmd
    {
        [StructLayout(LayoutKind.Sequential), Cmd]
        public struct EmitAssemblyReferences
        {
            public FS.FilePath Source;

            public FS.FilePath Target;
        }

        [CmdWorker]
        public static void exec(IWfShell wf, in EmitAssemblyReferences cmd)
        {
            var host = Cmd.host(cmd);
            using var reader = Reader(wf,cmd.Source);
            using var writer = cmd.Target.Writer();
            var data = reader.AssemblyReferences();
            var count = data.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(data,i).Name);
        }

        [MethodImpl(Inline)]
        static CliMemoryMap Reader(IWfShell wf, FS.FilePath src)
            => CliMemoryMap.create(wf, src);
    }
}