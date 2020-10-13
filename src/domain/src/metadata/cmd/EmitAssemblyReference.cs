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
        [StructLayout(LayoutKind.Sequential)]
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
            var data = reader.AssemblyReferences();
            var count = data.Length;
            for(var i=0; i<count; i++)
                wf.Status(host, skip(data,i).Name);
        }

        [MethodImpl(Inline)]
        static CliMemoryReader Reader(IWfShell wf, FS.FilePath src)
            => CliMemoryReader.create(wf, src);

        public ref EmitAssemblyReferences spec(FS.FilePath src, FS.FilePath dst,  out EmitAssemblyReferences cmd)
        {
            cmd = default;
            cmd.Source = src;
            cmd.Target = dst;
            return ref cmd;
        }
    }
}