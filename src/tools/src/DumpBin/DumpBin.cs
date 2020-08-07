//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Pow2x32;

    public partial struct DumpBin
    {
        public static DumpBin init(FolderPath src, FolderPath dst)
            => new DumpBin(src,dst);
        
        public Flag Flags;

        public readonly FolderPath SourceDir;
        
        public readonly FolderPath TargetDir;
        
        readonly Archive archive;

        public DumpBin(FolderPath src, FolderPath dst)
        {
            SourceDir = src;
            TargetDir = dst;
            archive = new Archive(dst);
            Flags = 0;
        }

        public Files Output(Flag f)
            => Files.from(archive.Dir(f).Files(archive.Ext(f)));

        static FilePath normalize(FilePath src)
            => FilePath.Define(src.Name.Replace('\\', '/'));

        [Flags]
        public enum Flag : uint
        {
            None = 0,

            ArchiveMembers = P2ᐞ00,
            
            ClrHeader = P2ᐞ01,
            
            Dependents = P2ᐞ02,
            
            Directives = P2ᐞ03,
            
            Disasm = P2ᐞ04,
            
            Exports = P2ᐞ05,
            
            Fpo = P2ᐞ06,
            
            Headers = P2ᐞ07,
            
            Imports = P2ᐞ08,
            
            LineNumbers = P2ᐞ09,
            
            LinkerMember = P2ᐞ10,
            
            LoadConfig = P2ᐞ11,
            
            RawData = P2ᐞ12,
            
            Relocations = P2ᐞ13,
            
            Summary = P2ᐞ14,
            
            Symbols = P2ᐞ15,
            
            Tls = P2ᐞ16,
        }
    }
}