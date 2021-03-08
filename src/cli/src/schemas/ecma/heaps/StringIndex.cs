//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.CompilerServices;

    using static Part;

    using static HeapIndexKinds;

    public readonly struct StringIndex : IHeapIndex<SystemStringIndexKind,SystemStringIndex>
    {
        public uint Key {get;}

        [MethodImpl(Inline)]
        public StringIndex(uint value)
            => Key = value;

        [MethodImpl(Inline)]
        public static implicit operator StringIndex(uint value)
            => new StringIndex(value);

        [MethodImpl(Inline)]
        public static implicit operator StringIndex(int value)
            => new StringIndex((uint)value);
    }
}