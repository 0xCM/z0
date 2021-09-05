//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FileKindNames;

    [SymSource]
    public enum FileKind : uint
    {
        None = 0,

        /// <summary>
        /// Text-formatted x86-encoded assembly
        /// </summary>
        [Symbol(hex, "Text-formatted x86-encoded assembly")]
        Hex,

        /// <summary>
        /// Formatted x86 assembly
        /// </summary>
        [Symbol(asm,"Formatted x86 assembly")]
        Asm,

        /// <summary>
        /// Text-formatted CIL instructions
        /// </summary>
        [Symbol(cil, "Msil source text")]
        Cil,

        /// <summary>
        ///  Delimited data rows
        /// </summary>
        [Symbol(csv,"Delimited data rows")]
        Csv,

        /// <summary>
        ///  A library module
        /// </summary>
        [Symbol(dll, "A library module")]
        Dll,

        /// <summary>
        ///  An executable module
        /// </summary>
        [Symbol(exe, "An executable module")]
        Exe,

        /// <summary>
        /// Text data
        /// </summary>
        [Symbol(txt,"Text data")]
        Txt,

        /// <summary>
        ///  Xml data
        /// </summary>
        [Symbol(xml, "Xml data")]
        Xml,

        /// <summary>
        /// Json data
        /// </summary>
        [Symbol(json, "Json data")]
        Json,

        /// <summary>
        /// Unprocessed x86-encoded data
        /// </summary>
        [Symbol(xcsv,"Unprocessed x86-encoded data")]
        XCsv,

        /// <summary>
        /// A symbol table file
        /// </summary>
        [Symbol(sym,"A  symbol table as emitted by llvm-nm ")]
        Sym,

        /// <summary>
        /// Text-formatted x86-encoded/executable data
        /// </summary>
        [Symbol(pcsv,"Text-formatted x86-encoded/executable data")]
        PCsv,

        [Symbol(log,"Text-formatted log data")]
        Log,

        [Symbol(csproj, "A CSharp project file")]
        CsProj,

        /// <summary>
        /// Application message/diagnostic log
        /// </summary>
        StdLog,

        /// <summary>
        /// Application error log
        /// </summary>
        ErrLog,

        /// <summary>
        /// Line-oriented hex data where each line is prefixed with an absolute/relative offset
        /// </summary>
        Dat,

        [Symbol(dmp, "A windows dump file")]
        Dmp,

        /// <summary>
        /// A binary file that contains a sequence of bytes
        /// </summary>
        [Symbol(bin, "A binary file that contains a sequence of bytes")]
        Bin,

        [Symbol(cmd, "A windows batch file")]
        Cmd,

        [Symbol(bat, "A windows batch file")]
        Bat,

        [Symbol(cs, "A csharp source file")]
        Cs,

        [Symbol(sql, "A sql script")]
        Sql,

        [Symbol(xpack, "Text-formatted hex with base addresses")]
        XPack,

        [Symbol(ildata, "MSIL organized in tabular format")]
        IlData,

        [Symbol(cpp, "A cpp source file")]
        Cpp,

        [Symbol(h, "A C/C++ header file")]
        H,

        [Symbol(mcasm)]
        McAsm,

        [Symbol(mcopsasm)]
        McOpsAsm,

        [Symbol(mcopslog)]
        McOpsLog,

        [Symbol(coffheaders)]
        CoffHeaders,

        [Symbol(objasm)]
        ObjAsm,

        [Symbol(objhex)]
        ObjHex,

        [Symbol(objyaml)]
        ObjYaml,

        [Symbol(yamltok)]
        YamlTok,

        [Symbol(ll)]
        Llir,

        [Symbol(mlir)]
        Mlir,

        [Symbol(mir)]
        Mir,
    }
}