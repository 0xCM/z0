//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class FileExtensions
    {
        public static FileExtension StatusLog
            => FileExtension.Define("status.log", "Application status log");

        public static FileExtension ErrorLog
            => FileExtension.Define("error.log", "Application error log");

        public static FileExtension Any
            => FileExtension.Define("*.*", "Wildcard");

        public static FS.FileExt Csv
            => FS.ext("csv");

        public static FileExtension Cs
            => FileExtension.Define("cs", "CSharp source text");

        public static FileExtension Asm
            => FileExtension.Define("asm", "Formatted x86 assembly");

        public static FileExtension Dll
            => FileExtension.Define("dll", "Application library");

        public static FileExtension Json
            => FileExtension.Define("json", "JSON file");

        public static FileExtension Exe
            => FileExtension.Define("exe", "Application executable");

        public static FS.FileExt Txt
            => FS.ext("txt", "Plaintext");

        public static FileExtension Il
            => FileExtension.Define("il", "Microsoft intermediate language");

        public static FileExtension HexLine
            => FileExtension.Define("hex", "Text-formated binary code");

        public static FileExtension Extract
            => FileExtension.Define("x.csv", "Raw x86 disassembly");

        public static FileExtension Parsed
            => FileExtension.Define("p.csv", "Parsed x86 disassembly");

        public static FileExtension Unparsed
            => FileExtension.Define("u.csv", "x86 disassembly failures");
    }
}