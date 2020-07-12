//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class FileExtensions
    {
        public static FileExtension Csv => FileExtension.Define("csv", "Structured text");

        public static FileExtension Cs => FileExtension.Define("cs", "CSharp source text");

        public static FileExtension Asm =>  FileExtension.Define("asm", "Formatted x86 assembly");

        public static FileExtension Dll =>  FileExtension.Define("dll", "Application library");

        public static FileExtension Xml =>  FileExtension.Define("xml", "Xml file");

        public static FileExtension Json =>  FileExtension.Define("json", "JSON file");

        public static FileExtension Exe =>  FileExtension.Define("exe", "Application executable");

        public static FileExtension Txt =>  FileExtension.Define("txt", "Plaintext");

        public static FileExtension Il =>  FileExtension.Define("il", "Microsoft intermediate language");

        public static FileExtension Hex =>  FileExtension.Define("hex", "Text-formated binary code");

        public static FileExtension Log =>  FileExtension.Define("log", "Application log");

        public static FileExtension StdOut =>  FileExtension.Define("stdout", "Standard output stream");

        public static FileExtension ErrOut =>  FileExtension.Define("errors", "Error output stream");   

        public static FileExtension Extract => FileExtension.Define("x.csv", "Raw x86 disassembly");

        public static FileExtension Parsed => FileExtension.Define("p.csv", "Parsed x86 disassembly");
    
        public static FileExtension Unparsed => FileExtension.Define("u.csv", "Unparseable x86 disassembly");

    }
}