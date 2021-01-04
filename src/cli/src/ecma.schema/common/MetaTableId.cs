//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct MetaTableId
    {
        public byte Value {get;}

        public MetaTableId(byte value)
            => Value = value;

        public static implicit operator MetaTableId(byte src)
            => new MetaTableId(src);

        public static implicit operator MetaTableId(HandleKind src)
            => new MetaTableId((byte)src);

        public static implicit operator MetaTableId(TableIndex src)
            => new MetaTableId((byte)src);
    }

    public readonly struct MetaTableId<T>
        where T : struct, IRecord<T>
    {
        public byte Value {get;}

        public MetaTableId(byte value)
            => Value = value;

        public static implicit operator MetaTableId<T>(byte src)
            => new MetaTableId<T>(src);

        public static implicit operator MetaTableId<T>(HandleKind src)
            => new MetaTableId<T>((byte)src);

        public static implicit operator MetaTableId<T>(TableIndex src)
            => new MetaTableId<T>((byte)src);
    }
}