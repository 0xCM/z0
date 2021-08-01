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

            [MethodImpl(Inline)]
            public static implicit operator mem<T>(T src)
                => new mem<T>(src);
        }

        public readonly struct m8 : IMemOp8<m8>
        {


        }

        public readonly struct m16 : IMemOp16<m16>
        {


        }

        public readonly struct m32 : IMemOp32<m32>
        {


        }

        public readonly struct m64 : IMemOp64<m64>
        {


        }

        public readonly struct m128 : IMemOp128<m128>
        {


        }

        public readonly struct m256 : IMemOp256<m256>
        {


        }

        public readonly struct m512 : IMemOp512<m512>
        {

        }
    }
}
