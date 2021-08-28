//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".env-logs")]
        Outcome EnvLogs(CmdArgs args)
        {
            var result = Outcome.Success;
            var ext = FS.ext("env") + FS.Log;
            var paths = Ws.Tools().AdminFiles(ext);
            var formatter = Tables.formatter<EnvVarSet>();
            foreach(var path in paths)
            {
                result = EnvVarSet.parse(path, out var dst);
                if(result.Fail)
                    return result;
                Write(formatter.Format(dst, RecordFormatKind.KeyValuePairs));
            }

            return result;
        }
    }
}