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

    partial struct PdbServices
    {

        public enum PdbKind : byte
        {
            None = 0,

            Portable,

            Legacy,
        }

        public class SymbolSource : IDisposable
        {
            public bool IsPortable {get;}

            public FS.FilePath PePath {get;}

            public BinaryCode PeData {get;}

            public MemoryStream PeStream {get;}

            public ByteSize PeSize
            {
                [MethodImpl(Inline)]
                get => PeData.Length;
            }

            public FS.FilePath PdbPath {get;}

            public BinaryCode PdbData {get;}

            public MemoryStream PdbStream {get;}

            public PdbKind PdbKind{get;}

            public ByteSize PdbSize
            {
                [MethodImpl(Inline)]
                get => PdbData.Length;
            }

            internal SymbolSource(byte[] pe, byte[] pdb)
            {
                PePath = FS.FilePath.Empty;
                PdbPath = FS.FilePath.Empty;
                PeData = pe;
                PdbData = pdb;
                PeStream = new MemoryStream(PeData);
                PdbStream = new MemoryStream(PdbData);
                IsPortable = portable(PdbData);
                PdbKind = pdbkind(PdbData);
            }

            internal SymbolSource(FS.FilePath pe, FS.FilePath pdb)
            {
                PePath = pe;
                PdbPath = pdb;
                PeData = File.ReadAllBytes(PePath.Name);
                PdbData = File.ReadAllBytes(PdbPath.Name);
                PeStream = new MemoryStream(PeData);
                PdbStream = new MemoryStream(PdbData);
                IsPortable = portable(PdbData);
                PdbKind = pdbkind(PdbData);
            }

            public void Dispose()
            {
                PeStream?.Dispose();
                PdbStream?.Dispose();
            }

            public static SymbolSource Empty
            {
                [MethodImpl(Inline)]
                get => new SymbolSource(sys.empty<byte>(), sys.empty<byte>());
            }
        }
    }
}