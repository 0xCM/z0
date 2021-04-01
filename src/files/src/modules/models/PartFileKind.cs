//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Hex8Seq;

    public enum PartFileKind : byte
    {
        /// <summary>
        /// Text-formatted x86-encoded assembly
        /// </summary>
        Hex = x00,

        /// <summary>
        /// Formatted assembly
        /// </summary>
        Asm = x01,

        /// <summary>
        /// Text-formatted CIL instructions
        /// </summary>
        Cil = x02,

        /// <summary>
        ///  Delimited data rows
        /// </summary>
        Csv = x03,

        /// <summary>
        ///  A library module, managed or otherwise
        /// </summary>
        Dll = x04,

        /// <summary>
        ///  An executable module
        /// </summary>
        Exe = x05,

        /// <summary>
        /// Text data
        /// </summary>
        Txt = x06,

        /// <summary>
        ///  Xml data
        /// </summary>
        Xml = x07,

        /// <summary>
        /// Json data
        /// </summary>
        Json = x08,

        /// <summary>
        /// Unprocessed x86-encoded data
        /// </summary>
        Extract = x09, //*.x.csv

        /// <summary>
        /// Text-formatted x86-encoded/executable data
        /// </summary>
        Parsed = x0a, //*.p.csv

        /// <summary>
        /// Application message/diagnostic log
        /// </summary>
        StdLog = x0b,

        /// <summary>
        /// Application error log
        /// </summary>
        ErrLog = x0c,

        /// <summary>
        /// Line-oriented hex data where each line is prefixed with an absolute/relative offset
        /// </summary>
        Dat = x0d,

        /// <summary>
        /// A text document of some sort
        /// </summary>
        Doc = x0e,

        /// <summary>
        /// A file produced by some sort of tool
        /// </summary>
        Tool = 128,
    }
}