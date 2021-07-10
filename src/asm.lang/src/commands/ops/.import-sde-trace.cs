//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.Tools;

    partial class AsmCmdService
    {
        [CmdOp(".import-sde-trace")]
        public Outcome ImportSdeTrace(CmdArgs args)
        {
            var path = Workspace.ArchiveDump("sde-data", FS.Log);
            using var reader = AsciLineReader.open(path);
            var counter = 0u;
            while(reader.Next(out var line))
            {
                counter++;
            }


            Write(string.Format("The source data {0} has {1} lines", path.ToUri(), counter));

            return true;
        }
    }
}