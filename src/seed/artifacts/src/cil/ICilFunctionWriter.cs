//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    /// <summary>
    /// Defines service contract for persistent emission of cil functions that accompany asm functions
    /// </summary>
    public interface ICilFunctionWriter : IService
    {
        /// <summary>
        /// The writer's destintation path
        /// </summary>
        FilePath Target {get;}        
        
        void Write(CilFunction[] src);     
    }
}