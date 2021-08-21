//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asm-hex-array")]
        Outcome AsmHexArray(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = AsmWs.HexOutDir().Files(FS.Hex).ToReadOnlySpan();
            var count = src.Length;
            var files = alloc<FS.FilePath>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                result = asm.hexbytes(path.ReadAsci(), out var code);
                if(result.Fail)
                    return result;

                var recoded = HexFormatter.array(code.View);
                var dst = OutDir("asmws") + path.FileName;
                using var writer = dst.AsciWriter();
                writer.WriteLine(recoded);
                Write(string.Format("{0} -> {1}", path.ToUri(), dst.ToUri()));
                seek(files,i) = dst;
            }
            Files(files,false);
            return result;
        }
    }
}