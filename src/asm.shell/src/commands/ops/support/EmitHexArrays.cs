//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using System;

    partial class AsmCmdService
    {
        Outcome EmitHexArrays(ReadOnlySpan<FS.FilePath> src, FS.FolderPath dir)
        {
            var result = Outcome.Success;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var dst = dir + FS.file(path.FileName.Format(), FS.XArray);
                var data = HexArray.cover(path.ReadBytes());
                var size = data.Length;
                using var writer = dst.AsciWriter();
                writer.WriteLine(data.Format(true));
                Write(string.Format("({0} bytes)[{1} -> {2}]", size, path.ToUri(), dst.ToUri()));
            }

            return result;
        }
    }
}