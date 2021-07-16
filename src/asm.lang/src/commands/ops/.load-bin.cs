//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".buffer-load")]
        Outcome BufferLoad(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            var path = Workspace.BinPath(id);
            var data = path.ReadBytes().ToReadOnlySpan();
            var size = data.Length;
            var msg = string.Format("Read {0} bytes from {1}", size, path.ToUri());
            Status(msg);
            result = NativeLoad(data);
            if(result)
                Write(string.Format("Injected data into execution buffer: {0}", data.FormatHex()));
            return result;
        }

        [CmdOp(".buffer-exec")]
        Outcome BufferExec(CmdArgs args)
        {
            var code = NativeBuffer(false);
            var f = DynamicOperations.emitter<ulong>("_buffer", (address(code), _NativeSize));
            var output = f.Operation.Invoke();
            Write(output);
            return true;
        }
    }
}