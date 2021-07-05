//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".load-bin")]
        Outcome LoadBin(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            var path = Workspace.BinPath(id);
            var data = path.ReadBytes().ToReadOnlySpan();
            var size = data.Length;
            var msg = string.Format("Read {0} bytes from {1}", size, path.ToUri());
            Status(msg);
            var buffer = NativeBuffer(true);
            if(size > buffer.Length)
                return (false,string.Format("Input exceeds capacity"));
            for(var i=0; i<size; i++)
                seek(buffer,i) = skip(data,i);

            Babble(string.Format("Injected data into execution buffer: {0}", data.FormatHex()));

            return result;
        }
    }
}