//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-sde-trace")]
        public Outcome ImportSdeTrace(CmdArgs args)
        {
            var path = OutDir("sde") + FS.file(arg(args,0).Value, FS.Log);
            using var reader = path.AsciLineReader();
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