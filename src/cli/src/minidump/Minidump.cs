//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = Windows;

    partial class Minidump
    {
        [Record(TableId)]
        public unsafe struct FileHeader : IRecord<FileHeader>
        {
            public const string TableId = "minidump.header";

            public asci4 Signature;

            public ushort Version;

            ushort _Filler1;

            /// <summary>
            /// The number of streams in the minidump directory.
            /// </summary>
            public Count StreamCount;

            /// <summary>
            /// The base RVA of the minidump directory
            /// </summary>
            public Address32 Streams;

            public ulong Timestamp;

            public Flags64<W.MinidumpType> Properties;
        }
    }

    public sealed partial class Minidump : IDisposable
    {
        readonly IWfRuntime Wf;

        readonly MemoryFile Source;

        public static Minidump open(IWfRuntime wf, FS.FilePath src)
            => new Minidump(wf,src);

        Minidump(IWfRuntime wf, FS.FilePath src)
        {
            Wf = wf;
            Source = MemoryFiles.map(src);
            Wf.Status($"Mapped file {Source.Path} to process memory based at {Source.BaseAddress}");
        }

        public ref readonly FileHeader Header
        {
            [MethodImpl(Inline)]
            get => ref Source.One<FileHeader>(0);
        }

        public void Dispose()
        {
            Source.Dispose();
        }

        public void Summarize()
        {
            var src = Wf.Db().DumpFilePath("capture");
            if(src.Exists)
            {
                var formatter = Tables.formatter<Minidump.FileHeader>();
                using var md = Minidump.open(Wf, src);
                var header = formatter.Format(md.Header, RecordFormatKind.KeyValuePairs);
                Wf.Row(header);
            }
            else
                Wf.Error($"The file {src} does not exist");
        }
    }
}