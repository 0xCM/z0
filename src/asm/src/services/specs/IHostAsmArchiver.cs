//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Defines service contract for persisting asm functions which are derived from .net member functions
    /// </summary>
    public interface IHostAsmArchiver : IService
    {
        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        PartId Owner {get;}

        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri ApiHost {get;}        

        /// <summary>
        /// Saves an array of functions, rendered as formatted asm code, to the archive
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveInjectedImmAsm(OpIdentity id, AsmFunction[] src, bool append);

        /// <summary>
        /// Saves an array of functions, rendered as lines of hex text, to the archive
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        Option<FilePath> SaveInjectedImmHex(OpIdentity id, AsmFunction[] src, bool append);       
    }    
}