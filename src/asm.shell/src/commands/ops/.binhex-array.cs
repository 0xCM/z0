//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".binhex-array", "state.files()[0..n] -> .out/binhex.raw/file(i).hex")]
        Outcome BinHexRaw(CmdArgs args)
        {
            var result = Outcome.Success;
            var paths = State.Files().View;
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(paths,i);
                var dst = OutDir("binhex.arrays") + FS.file(src.FileName.Format(), FS.XArray);
                var data = HexArray.cover(src.ReadBytes());
                var size = data.Length;
                using var writer = dst.AsciWriter();
                writer.WriteLine(data.Format(true));
                Write(string.Format("({0} bytes)[{1} -> {2}]", size, src.ToUri(), dst.ToUri()));
            }

            return result;
        }
    }
}