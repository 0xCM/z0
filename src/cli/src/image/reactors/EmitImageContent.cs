//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
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

        protected override CmdResult Run(EmitImageContentCmd cmd)
        {
            using var flow = Wf.Running();
            using var stream = cmd.Source.ImagePath.Reader();
            using var reader = stream.BinaryReader();
            using var dst = cmd.Target.Writer();
            dst.WriteLine(text.concat($"Address".PadRight(12), SpacePipe, "Data"));

            var buffer = span<byte>(ImageContentRecord.RowDataSize);
            var k = Read(reader,buffer);
            var offset = 0u;
            var linecount = 0u;
            var formatter = Formatters.data(cmd.Source.BaseAddress);
            while(k != 0)
            {
                dst.WriteLine(formatter.FormatLine(buffer, offset, FieldDelimiter));

                offset += k;
                linecount++;

                buffer.Clear();
                k = Read(reader, buffer);
            }

            Wf.EmittedTable<ImageContentRecord>(Host, linecount, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}