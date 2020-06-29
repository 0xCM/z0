//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines an enclosure for a single operand
    /// </summary>
    public readonly struct Bound<T>
        where T : unmanaged, IOperand
    {
        public readonly T A;

        [MethodImpl(Inline)]
        public Bound(T arg0)
        {
            A = arg0;
        }
    }
}