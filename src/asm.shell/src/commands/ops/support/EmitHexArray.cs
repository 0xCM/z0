//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        ByteSize EmitHexArray(byte[] src, FS.FilePath dst)
        {
            var array = Hex.hexarray(src);
            var size = src.Length;
            var flow = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            writer.WriteLine(array.Format(false));
            EmittedFile(flow, size);
            return size;
        }
    }
}