//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    public readonly struct ByteSpanProp
    {
        public MemberInfo Member {get;}

        public BinaryCode MemberCode {get;}

        public MemoryAddress StorageLocation {get;}

        public ByteSize DataSize {get;}

        [MethodImpl(Inline)]
        public ByteSpanProp(MemberInfo def, BinaryCode code, MemoryAddress location, ByteSize size)
        {
            Member = def;
            MemberCode = code;
            StorageLocation = location;
            DataSize = size;
        }

        public ReadOnlySpan<byte> StoredBytes
        {
            [MethodImpl(Inline)]
            get => cover<byte>(StorageLocation, DataSize);
        }
    }

}