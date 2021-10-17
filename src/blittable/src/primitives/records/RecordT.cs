//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitRecords
    {
        /// <summary>
        /// Defines a record backed byte a <typeparamref name='T'/> storage cell
        /// </summary>
        public struct Record<T>
            where T : unmanaged
        {
            T Data;

            [MethodImpl(Inline)]
            public Record(T data)
            {
                Data = data;
            }

            public Span<byte> Storage
            {
                [MethodImpl(Inline)]
                get => bytes(Data);
            }
        }
    }
}