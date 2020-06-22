//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Defines file extensions common to all archives
    /// </summary>
    public interface TArchiveExtensions
    {
        /// <summary>
        /// Extension for hex files
        /// </summary>
        FileExtension Hex => FileExtensions.Hex;

        /// <summary>
        /// Extension for formatted asm files
        /// </summary>
        FileExtension Asm => FileExtensions.Asm;

        /// <summary>
        /// Extension for Cil files
        /// </summary>
        FileExtension Il => FileExtensions.Il;

        /// <summary>
        /// Extension for application log files
        /// </summary>
        FileExtension Log => FileExtensions.Log;
    }
}