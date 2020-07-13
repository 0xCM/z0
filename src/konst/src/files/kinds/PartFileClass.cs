//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum PartFileClass : byte
    {
        None = 0,

        /// <summary>
        /// Indicates a CSV file that contains unprocessed/unexecutable x86-encoded data
        /// </summary>
        Extract = 1, //*.x.csv
        
        /// <summary>
        /// Indicates a CSV file that contains text-formatted x86-encoded/executable data
        /// </summary>
        Parsed = 2, //*.p.csv

        /// <summary>
        /// Indicates formated asm
        /// </summary>
        Asm = 3, 

        /// <summary>
        /// Indicates text-formatted x86-encoded assembly
        /// </summary>
        Hex = 4,

        /// <summary>
        /// Indicates text-formatted CIL instructions
        /// </summary>
        Cil = 5,        
    }   
}