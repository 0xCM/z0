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
    using static memory;

    public struct ImageContentEmitter
    {
        readonly IWfShell Wf;

        //readonly WfHost Host;

        // readonly MemoryAddress BaseAddress;

        // readonly FS.FilePath TargetPath;

        // readonly FS.FilePath SourcePath;

        // MemoryAddress Offset;

        // readonly uint BufferSize;

        //uint LineCount;

        const char LabelDelimiter = Chars.Pipe;

        //readonly HexDataFormatter Formatter;

        // [MethodImpl(Inline)]
        // ImageContentEmitter(IWfShell wf, IPart part)
        // {
        //     Host = WfShell.host(typeof(ImageContentEmitter));
        //     Wf = wf.WithHost(Host);
        //     BaseAddress = ImageMaps.@base(part);
        //     TargetPath = Wf.Db().Table(ImageContent.TableId, part.Id);
        //     BufferSize = ImageContent.RowDataSize;
        //     Formatter = Hex.formatter(BaseAddress, (ushort)BufferSize);
        //     Offset = 0;
        //     LineCount = 0;
        //     LabelDelimiter = Chars.Pipe;
        //     SourcePath = FS.path(part.Owner.Location);
        //     Wf.Created();
        // }

        ImageContentEmitter(IWfShell wf)
        {
            Wf = wf;
        }

        // public void Dispose()
        // {
        //     Wf.Disposed();
        // }

        public static Index<LocatedPart> emit(IWfShell wf)
        {
            var emitter = new ImageContentEmitter(wf);
            return emitter.Emit();
            // var src = wf.Api.Parts;
            // var count = src.Length;
            // var buffer = alloc<LocatedPart>(count);
            // ref var located = ref first(buffer);
            // for(var i=0u; i<count; i++)
            // {
            //     ref readonly var part = ref skip(src, i);
            //     using var step = new ImageContentEmitter(wf, part);
            //     step.EmitContent();
            //     var @base = ImageMaps.@base(part);
            //     seek(located,i) = new LocatedPart(part, @base, (ulong)step.OffsetAddress - (ulong)@base);
            // }

            // return buffer;
        }

        public Index<LocatedPart> Emit()
        {
            var src = Wf.Api.Parts;
            var count = src.Length;
            var buffer = alloc<LocatedPart>(count);
            ref var located = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var part = ref skip(src, i);
                var @base = ImageMaps.@base(part);
                var target = Emit(part, out var offset);
                seek(located,i) = new LocatedPart(part, @base, (ulong)offset - (ulong)@base);

            }
            return buffer;
        }

        FS.FilePath Emit(IPart part, out MemoryAddress offset)
        {
            offset = MemoryAddress.Zero;
            var @base = ImageMaps.@base(part);
            var flow = Wf.Running(part.Id.Format());
            var source = FS.path(part.Owner.Location);
            var target = Wf.Db().Table(ImageContent.TableId, part.Id);
            var formatter = Hex.formatter(@base, (ushort)ImageContent.RowDataSize);
            using var stream = source.Reader();
            using var reader = stream.BinaryReader();
            using var dst = target.Writer();
            var inner = Wf.EmittingTable<ImageContent>(target);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            var counter = 0;
            var buffer = span<byte>(ImageContent.RowDataSize);
            var k = Read(reader,buffer);
            while(k != 0)
            {
                dst.WriteLine(formatter.FormatLine(buffer, offset, LabelDelimiter));

                offset += k;
                counter++;

                buffer.Clear();
                k = Read(reader, buffer);
            }

            Wf.EmittedTable<ImageContent>(inner, counter);
            Wf.Ran(flow);
            return target;
        }

        // void EmitContent()
        // {
        //     var flow = Wf.Running();
        //     using var stream = SourcePath.Reader();
        //     using var reader = stream.BinaryReader();
        //     using var dst = TargetPath.Writer();
        //     var inner = Wf.EmittingTable<ImageContent>(TargetPath);
        //     dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));

        //     var buffer = span<byte>(BufferSize);
        //     var k = Read(reader,buffer);
        //     while(k != 0)
        //     {
        //         dst.WriteLine(Formatter.FormatLine(buffer, Offset, LabelDelimiter));

        //         Offset += k;
        //         LineCount++;

        //         buffer.Clear();
        //         k = Read(reader, buffer);
        //     }

        //     Wf.EmittedTable<ImageContent>(inner, LineCount);
        //     Wf.Ran(flow);
        // }

        // public MemoryAddress OffsetAddress
        // {
        //     [MethodImpl(Inline)]
        //     get => Offset;
        // }

        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);
    }
}