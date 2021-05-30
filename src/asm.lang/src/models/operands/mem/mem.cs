//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOps
    {
        /// <summary>
        /// Defines a 128-bit memory operand
        /// </summary>
        public struct mem<T> : IMemOp<mem<T>>
            where T : unmanaged
        {
            public T Content;

            [MethodImpl(Inline)]
            public mem(T content)
            {
                Content = content;
            }

            [MethodImpl(Inline)]
            public static implicit operator mem<T>(T content)
                => new mem<T>(content);
        }
    }
}
