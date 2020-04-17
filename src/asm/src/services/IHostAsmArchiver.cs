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
        PartId DefiningPart {get;}

        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri ApiHost {get;}        

        /// <summary>
        /// Saves a group of related functtions to the archive
        /// </summary>
        /// <param name="group">The source group</param>
        void Save(AsmFunctionGroup group, bool append);

        Option<FilePath> SaveAsm(AsmFunction[] src, bool append);

        Option<FilePath> SaveHex(AsmFunction[] src, bool append);
        
        void Clear();
    }    
}