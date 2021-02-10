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
        readonly IWfShell Wf;

        readonly MemoryFile Source;

        public static Minidump open(IWfShell wf, FS.FilePath src)
            => new Minidump(wf,src);

        Minidump(IWfShell wf, FS.FilePath src)
        {
            Wf = wf;
            Source = MemoryFiles.map(src);
            Wf.Status($"Mapped file {Source.Path} to process memory based at {Source.BaseAddress}");
            // asci4 sig = header.Signature;
            // Wf.Row(string.Format("Sig:{0}, Version:{1}, NumerOfStreams:{2}, Flags:{3}",
            //     sig, header.Version & ushort.MaxValue, header.NumberOfStreams, header.Flags));

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
    }
}