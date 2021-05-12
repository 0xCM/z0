//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FileKindNames;

    [SymbolSource]
    public enum FileKind : uint
    {
        None = 0,

        /// <summary>
        /// Text-formatted x86-encoded assembly
        /// </summary>
        [Symbol(hex)]
        Hex,

        /// <summary>
        /// Formatted assembly
        /// </summary>
        [Symbol(asm)]
        Asm,

        /// <summary>
        /// Text-formatted CIL instructions
        /// </summary>
        [Symbol(cil)]
        Cil,

        /// <summary>
        ///  Delimited data rows
        /// </summary>
        [Symbol(csv)]
        Csv,

        /// <summary>
        ///  A library module, managed or otherwise
        /// </summary>
        [Symbol(dll)]
        Dll,

        /// <summary>
        ///  An executable module
        /// </summary>
        [Symbol(exe)]
        Exe,

        /// <summary>
        /// Text data
        /// </summary>
        [Symbol(txt)]
        Txt,

        /// <summary>
        ///  Xml data
        /// </summary>
        [Symbol(xml)]
        Xml,

        /// <summary>
        /// Json data
        /// </summary>
        Json,

        /// <summary>
        /// Unprocessed x86-encoded data
        /// </summary>
        [Symbol(xcsv)]
        XCsv,

        /// <summary>
        /// Text-formatted x86-encoded/executable data
        /// </summary>
        [Symbol(pcsv)]
        PCsv,


        [Symbol(log)]
        Log,

        [Symbol(csproj)]
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

        [Symbol(bin, "A binary file of some sort, usually flat")]
        Bin,

        [Symbol(cmd, "A windows batch file")]
        Cmd,

        [Symbol(bat, "A windows batch file")]
        Bat,
    }
}