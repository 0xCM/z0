//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines service contract for persistent emission of cil functions that accompany asm functions
    /// </summary>
    public interface ICilFunctionWriter
    {
        /// <summary>
        /// The writer's destintation path
        /// </summary>
        FS.FilePath Target {get;}

        void Write(CilFunction[] src);
    }
}