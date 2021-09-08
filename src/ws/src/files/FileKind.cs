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

        [Symbol(hex, "Text-formatted x86-encoded assembly")]
        Hex,

        [Symbol(asm,"Formatted x86 assembly")]
        Asm,

        [Symbol(cil, "Msil source text")]
        Cil,

        [Symbol(csv,"Delimited data rows")]
        Csv,

        [Symbol(dll, "A library module")]
        Dll,

        [Symbol(exe, "An executable module")]
        Exe,

        [Symbol(txt,"Text data")]
        Txt,

        [Symbol(xml, "Xml data")]
        Xml,

        [Symbol(json, "Json data")]
        Json,

        [Symbol(xcsv,"Unprocessed x86-encoded data")]
        XCsv,

        [Symbol(sym,"A  symbol table as emitted by llvm-nm ")]
        Sym,

        [Symbol(pcsv,"Text-formatted x86-encoded/executable data")]
        PCsv,

        [Symbol(log,"Text-formatted log data")]
        Log,

        [Symbol(csproj, "A CSharp project file")]
        CsProj,

        [Symbol(dmp, "A windows dump file")]
        Dmp,

        [Symbol(obj, "A coff object file")]
        Obj,

        [Symbol(o, "A coff object file")]
        O,

        [Symbol(bin, "A flat binary file")]
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

        [Symbol(hexdat)]
        HexDat,

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