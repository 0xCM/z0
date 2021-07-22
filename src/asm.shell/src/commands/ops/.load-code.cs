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
        [CmdOp(".load-code")]
        Outcome LoadCode(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            var path = AsmWs.BinPath(id);
            var data = path.ReadBytes().ToReadOnlySpan();
            var size = data.Length;
            var msg = string.Format("Read {0} bytes from {1}", size, path.ToUri());
            Status(msg);
            result = LoadCodeBuffer(id, data);
            if(result)
                Write(string.Format("Injected data into execution buffer: {0}", data.FormatHex()));
            return result;
        }

        Outcome LoadCodeBuffer(string name, ReadOnlySpan<byte> src)
        {
            RoutineName = name;
            CodeBuffer.Clear();
            var size = src.Length;
            if(size > CodeBuffer.Size)
                return (false, CapacityExceeded.Format());

            var buffer = CodeBuffer.Edit;
            for(var i=0; i<size; i++)
                seek(buffer,i) = skip(src,i);
            CodeSize = size;
            return true;
        }
    }
}