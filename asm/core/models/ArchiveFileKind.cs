//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    /// <summary>
    /// Enumerates the kinds of files one finds in the asm archive
    /// </summary>
    public enum ArchiveFileKind
    {
        None = 0,
    
        /// <summary>
        /// Indicates text format x86-encoded assembly data
        /// </summary>
        Hex = 1,

        /// <summary>
        /// Indicates text format for x86-decoded assembly data
        /// </summary>
        Asm = 2,

        /// <summary>
        /// Indicates text format .net cil instructions
        /// </summary>
        Cil = 3,        

        /// <summary>
        /// Indicates text format for raw x86-encoded buffer data
        /// </summary>
        Raw = 4,
    }
}