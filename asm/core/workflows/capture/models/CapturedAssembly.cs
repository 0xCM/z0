//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Binds an assembly together with its captured operations 
    /// </summary>
    public readonly struct CapturedAssembly
    {
        /// <summary>
        /// The assembly id
        /// </summary>
        public readonly PartId Assembly;

        /// <summary>
        /// The captured operations
        /// </summary>
        public readonly CapturedOp[] Captured;        

        [MethodImpl(Inline)]
        public static CapturedAssembly Define(PartId owner, CapturedOp[] ops)
            => new CapturedAssembly(owner, ops);
        
        [MethodImpl(Inline)]
        CapturedAssembly(PartId id, CapturedOp[] ops)
        {
            this.Assembly = id;
            this.Captured = ops;
        }
    }
}