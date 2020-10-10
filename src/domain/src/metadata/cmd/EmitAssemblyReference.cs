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

    partial struct ClrCommands
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EmitAssemblyReferences
        {
            public ClrCmdKey CmdId;

            public FS.FilePath Source;

            public FS.FilePath Target;
        }

        [MethodImpl(Inline)]
        static ClrCmdHost<T> Host<T>(T t = default)
            where T : struct
                => ClrCmdHost<T>.create();

        [MethodImpl(Inline)]
        static ImageMap Reader(IWfShell wf, FS.FilePath src)
            => ImageMap.create(wf, src);

        public static ReadOnlySpan<CliAssemblyReferenceRecord> exec(IWfShell wf, in EmitAssemblyReferences cmd)
        {
            var host = Host(cmd);
            using var reader = Reader(wf,cmd.Source);
            var data = reader.AssemblyReferences();
            var count = data.Length;
            for(var i=0; i<count; i++)
            {
                wf.Status(host, skip(data,i).Name);
            }
            return data;
        }
    }
}