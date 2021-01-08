//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    sealed class EmitImageContent : CmdReactor<EmitImageContentCmd>
    {
        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);

        protected override CmdResult Run(EmitImageContentCmd cmd)
        {
            var flow = Wf.EmittingFile(cmd.Target);
            //using var stream = cmd.Source.ImagePath.Reader();
            //using var reader = stream.BinaryReader();
            MemoryEmitter.emit(cmd.Source.BaseAddress, cmd.Source.Size, cmd.Target);
            Wf.EmittedFile(flow, cmd.Target);

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