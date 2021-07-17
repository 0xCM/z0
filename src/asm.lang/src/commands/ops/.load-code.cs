//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".load-code")]
        Outcome LoadCode(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            var path = Workspace.BinPath(id);
            var data = path.ReadBytes().ToReadOnlySpan();
            var size = data.Length;
            var msg = string.Format("Read {0} bytes from {1}", size, path.ToUri());
            Status(msg);
            result = LoadRoutine(id, data);
            if(result)
                Write(string.Format("Injected data into execution buffer: {0}", data.FormatHex()));
            return result;
        }
    }
}