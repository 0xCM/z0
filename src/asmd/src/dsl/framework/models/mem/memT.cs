//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;

    /// <summary>
    /// Defines an M-parametric memory cell
    /// </summary>
    public readonly struct mem<M> : IMemOp<M>
        where M : unmanaged, IMemOp
    {
        public readonly M Data;

        [MethodImpl(Inline)]
        public static implicit operator mem<M>(M src)
            => new mem<M>(src);

        [MethodImpl(Inline)]
        public static implicit operator M(mem<M> src)
            => src.Data;

        public BitSize Width 
        {
            [MethodImpl(Inline)]
            get => bitsize<M>();
        }

        M IOperand<M>.Content 
            => Data;

        [MethodImpl(Inline)]
        public mem(M value)
        {
            Data = value;
        }
    }
}