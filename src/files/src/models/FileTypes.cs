//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class FileTypes
    {
        public static AsmFileType Asm => default(AsmFileType);

        public static BinFileType Bin => default(BinFileType);

        public static CsFileType Cs => default(CsFileType);

        public static DllFileType Dll => default(DllFileType);

        public static ExeFileType Exe => default(ExeFileType);

        public static SqlFileType Sql => default(SqlFileType);

        public static XPackType XPack => default(XPackType);

        public static IlDataType IlData => default(IlDataType);

        public static CppType Cpp => default(CppType);

        public static LogType Log => default(LogType);

        public readonly struct ExeFileType : IFileType<ExeFileType>
        {
            public FileKind FileKind => FileKind.Exe;

            public FS.FileExt FileExt => FS.Exe;
        }

        public readonly struct DllFileType : IFileType<DllFileType>
        {
            public FileKind FileKind => FileKind.Dll;

            public FS.FileExt FileExt => FS.Dll;
        }

        public readonly struct AsmFileType : IFileType<AsmFileType>
        {
            public FileKind FileKind => FileKind.Asm;

            public FS.FileExt FileExt => FS.Asm;
        }

        public readonly struct BinFileType : IFileType<BinFileType>
        {
            public FileKind FileKind => FileKind.Bin;

            public FS.FileExt FileExt => FS.Bin;
        }

        public readonly struct CsFileType : IFileType<CsFileType>
        {
            public FileKind FileKind => FileKind.Cs;

            public FS.FileExt FileExt => FS.Cs;
        }

        public readonly struct SqlFileType : IFileType<SqlFileType>
        {
            public FileKind FileKind => FileKind.Sql;

            public FS.FileExt FileExt => FS.Sql;
        }

        public readonly struct XPackType : IFileType<XPackType>
        {
            public FileKind FileKind => FileKind.XPack;

            public FS.FileExt FileExt => FS.XPack;
        }

        public readonly struct IlDataType : IFileType<IlDataType>
        {
            public FileKind FileKind => FileKind.IlData;

            public FS.FileExt FileExt => FS.IlData;
        }

        public readonly struct CppType : IFileType<CppType>
        {
            public FileKind FileKind => FileKind.Cpp;

            public FS.FileExt FileExt => FS.Cpp;
        }

        public readonly struct LogType : IFileType<LogType>
        {
            public FileKind FileKind => FileKind.Log;

            public FS.FileExt FileExt => FS.Log;
        }
    }
}