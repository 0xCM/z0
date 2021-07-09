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

    partial struct XedModels
    {
        public readonly struct AttributeVector
        {
            readonly ulong Data;

            [MethodImpl(Inline)]
            internal AttributeVector(ulong data)
            {
                Data = data;
            }

            public AttributeKind Component(byte index)
            {
                var offset = (byte)(8*index);
                return (AttributeKind)Bits.slice(Data,offset,8);
            }
        }
    }
}