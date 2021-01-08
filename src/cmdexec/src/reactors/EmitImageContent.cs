//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    sealed class EmitImageContent : CmdReactor<EmitImageContentCmd>
    {
        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);

        void Emit(MemoryRange src, StreamWriter dst)
        {
            const ushort PageSize = 0x1000;
            var buffer = span<byte>(PageSize);
            var pages = (uint)(src.Length/PageSize);
            var reader = memory.reader<byte>(src);
            var offset = 0ul;
            var formatter = Formatters.data(src.BaseAddress);
            for(var i=0; i<pages; i++)
            {
                var size = reader.Read((int)offset, PageSize, buffer);
                var lines = formatter.FormatLines(slice(buffer,size));
                for(var j =0; j<lines.Length; j++)
                    dst.WriteLine(skip(lines,j));

                if(size < PageSize)
                    break;

                offset += PageSize;
            }
        }

        protected override CmdResult Run(EmitImageContentCmd cmd)
        {
            using var flow = Wf.Running();
            //using var stream = cmd.Source.ImagePath.Reader();
            //using var reader = stream.BinaryReader();
            using var dst = cmd.Target.Writer();
            dst.WriteLine(text.concat($"Address".PadRight(12), SpacePipe, "Data"));

            MemoryRange range = (cmd.Source.BaseAddress,  cmd.Source.BaseAddress + cmd.Source.Size);
            Emit(range, dst);

            // var buffer = span<byte>(ImageContent.RowDataSize);
            // var k = Read(reader, buffer);
            // var offset = 0u;
            // var linecount = 0u;
            // var formatter = Formatters.data(cmd.Source.BaseAddress);
            // while(k != 0)
            // {
            //     dst.WriteLine(formatter.FormatLine(buffer, offset, FieldDelimiter));

            //     offset += k;
            //     linecount++;

            //     buffer.Clear();
            //     k = Read(reader, buffer);
            // }

            // Wf.EmittedTable<ImageContent>(Host, linecount, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}