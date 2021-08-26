//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        /// <summary>
        /// Defines a memory operend
        /// </summary>
        public struct mem<T> : IMemOp<mem<T>>
            where T : unmanaged, IMemOp
        {
            public T Spec;

            [MethodImpl(Inline)]
            public mem(T src)
            {
                Spec = src;
            }

            public AsmSize Size
            {
                [MethodImpl(Inline)]
                get => Spec.Size;
            }

            public AsmAddress Address
            {
                [MethodImpl(Inline)]
                get => Spec.Address;
            }

            [MethodImpl(Inline)]
            public static implicit operator mem<T>(T src)
                => new mem<T>(src);
        }
    }
}
