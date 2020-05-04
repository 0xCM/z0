//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Defines service contract for persisting asm functions which are derived from .net member functions
    /// </summary>
    public interface IHostArchiver : IService
    {
        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        PartId Owner {get;}

        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri Host {get;}        

        /// <summary>
        /// The directory into which the archiver archives
        /// </summary>
        FolderPath ArchiveRoot {get;}

        /// <summary>
        /// Saves the encoded data contained in an array of dedoded functions
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveHex(AsmFunction[] src, bool append);   

        /// <summary>
        /// Saves an array of functions as formatted asm
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveAsm(AsmFunction[] src, bool append);       

        /// <summary>
        /// Saves an array of functions as formatted asm
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveImmInjectedAsm(OpIdentity id, AsmFunction[] src, bool append);

        /// <summary>
        /// Saves the encoded data contained in an array of dedoded functions
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveImmInjectedHex(OpIdentity id, AsmFunction[] src, bool append); 
    }    
}