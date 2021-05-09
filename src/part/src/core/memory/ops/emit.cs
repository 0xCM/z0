//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [Op]
        public unsafe static uint emit(MemorySeg src, uint bpl, FS.FilePath dst)
        {
            var line = text.buffer();
            using var writer = dst.Writer();

            var pSrc = src.BaseAddress.Pointer<byte>();
            var last =  src.LastAddress.Pointer<byte>();
            var current = MemoryAddress.Zero;
            var offset = 1;
            var restart = true;

            while(pSrc++ <= last)
            {
                current = (MemoryAddress)pSrc;

                if(restart)
                {
                    line.Append(text.format("0x{0} ", current.Format()));
                    restart = false;
                }

                line.Append(text.format("{0} ", HexFormat.format<W8,byte>(*pSrc)));

                if(offset % bpl == 0)
                {
                    writer.WriteLine(line.Emit());
                    restart = true;
                }

                offset++;
            }
            writer.WriteLine(line.Emit());
            return (uint)offset;
        }
    }
}