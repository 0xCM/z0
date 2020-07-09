//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CallTarget
    {
        /// <summary>
        /// The target's operation identifier
        /// </summary>
        public readonly OpIdentity Id;
        
        /// <summary>
        /// The target's base address
        /// </summary>
        public readonly MemoryAddress Base;

        [MethodImpl(Inline)]
        public CallTarget(OpIdentity id, MemoryAddress @base)
        {
            Id = id;
            Base = @base;
        }       
    }
}