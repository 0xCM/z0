//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFileExtensions : IPartLogExtensions
    {
        /// <summary>
        /// Extract log extension
        /// </summary>
        FileExtension Extract => FileExtensions.Extract;

        /// <summary>
        /// Parse log extension
        /// </summary>
        FileExtension Parsed => FileExtensions.Parsed;

        /// <summary>
        /// Parse failure log extension
        /// </summary>
        FileExtension Unparsed => FileExtensions.Unparsed;

        /// <summary>
        /// Extension for hex files
        /// </summary>
        FileExtension HexLine => FileExtensions.HexLine;

        /// <summary>
        /// Extension for formatted asm files
        /// </summary>
        FileExtension Asm => FileExtensions.Asm;

        /// <summary>
        /// Extension for Cil files
        /// </summary>
        FileExtension Il => FileExtensions.Il;

        /// <summary>
        /// Extension for Cil data files
        /// </summary>
        FileExtension IlData => FileExtension.Define($"{Il}.{HexLine}");

        /// <summary>
        /// Extension for nonexecutable part components
        /// </summary>
        FileExtension Dll => FileExtensions.Dll;

        /// <summary>
        /// Extension for executable part components
        /// </summary>
        FileExtension Exe => FileExtensions.Exe;

        /// <summary>
        /// Extension for CSharp code files
        /// </summary>
        FileExtension Cs => FileExtensions.Cs;

        /// <summary>
        /// Extension for part configuration files
        /// </summary>
        FileExtension Config =>  FileExtensions.Json;
    }
}