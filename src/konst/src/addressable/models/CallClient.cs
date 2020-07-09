//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CallClient
    {
        /// <summary>
        /// The clients's operation identifier
        /// </summary>
        public readonly OpIdentity Id;
        
        /// <summary>
        /// The clients's base address
        /// </summary>
        public readonly MemoryAddress Base;

        [MethodImpl(Inline)]
        public CallClient(OpIdentity id, MemoryAddress @base)
        {
            Id = id;
            Base = @base;
        }       
    }
}