//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".binhex")]
        Outcome BinToHex(CmdArgs args)
        {
            var result = Outcome.Success;
            var paths = Files().View;
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(paths,i);
                var dst = OutDir("binhex") + FS.file(src.FileName.Format(),FS.Hex);
                var data = src.ReadBytes();
                var size = (ByteSize)MemoryEmitter.emit(data,40,dst);
                Write(string.Format("({0} bytes)[{1} -> {2}]", size, src.ToUri(), dst.ToUri()));
            }

            return result;
        }
    }
}