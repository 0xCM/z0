//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;


    public partial struct ProcDump : ITool<ProcDump>
    {
        [StringLiteral]
        const string ToolName = "procdump.exe";

        public IToolArchive<ProcDump> Archive {get;}

        public Outcome<FS.FilePath> Capture(string name, int pid)
        {
            var dst = Archive.ToolOutput + FS.file($"{name}.{pid}.dmp");
            var args = $"/accepteula -ma {pid} -x {dst}";
            var process = Process.Start(ToolName, args);
            process.WaitForExit();
            return dst;
        }
    }

}