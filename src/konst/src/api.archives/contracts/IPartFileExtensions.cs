//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFileExtensions
    {
        /// <summary>
        /// Extension for hex files
        /// </summary>
        FileExtension HexLine => FileExtensions.HexLine;

        /// <summary>
        /// Extension for formatted asm files
        /// </summary>
        FileExtension Asm => FileExtensions.Asm;


    }
}