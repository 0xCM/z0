//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    public readonly struct StringIndex : ICliHeapKey<StringIndex>
    {
        public CliHeapKind HeapKind => CliHeapKind.String;

        public uint Value {get;}

        [MethodImpl(Inline)]
        public StringIndex(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public StringIndex(StringHandle value)
            => Value = memory.u32(value);

        public string Format()
            => Value.ToString("X");

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CliHeapKey(StringIndex src)
            => new CliHeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator StringIndex(StringHandle src)
            => new StringIndex(src);
    }
}