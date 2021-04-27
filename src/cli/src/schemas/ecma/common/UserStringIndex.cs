//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct UserStringIndex : IHeapKey<UserStringIndex>
    {
        public HeapKind HeapKind => HeapKind.UserString;

        public uint Value {get;}

        [MethodImpl(Inline)]
        public UserStringIndex(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator HeapKey(UserStringIndex src)
            => new HeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator HeapKey<UserStringHeap>(UserStringIndex src)
            => new HeapKey<UserStringHeap>(src.Value);
    }
}