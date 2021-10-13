//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        /// <summary>
        /// Defines a record backed by an array of bytes
        /// </summary>
        public struct Record
        {
            readonly Index<byte> Data;

            [MethodImpl(Inline)]
            public Record(byte[] data)
            {
                Data = data;
            }

            public Span<byte> Storage
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }
        }
    }
}