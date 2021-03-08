//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.CompilerServices;

    using static Part;

    using static HeapIndexKinds;

    public readonly struct SystemStringIndex : IHeapIndex<SystemStringIndexKind,SystemStringIndex>
    {
        public uint Key {get;}

        [MethodImpl(Inline)]
        public SystemStringIndex(uint value)
            => Key = value;

        [MethodImpl(Inline)]
        public static implicit operator SystemStringIndex(uint value)
            => new SystemStringIndex(value);

        [MethodImpl(Inline)]
        public static implicit operator SystemStringIndex(int value)
            => new SystemStringIndex((uint)value);
    }
}