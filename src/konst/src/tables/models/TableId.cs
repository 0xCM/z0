//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableId : ITableId
    {
        public StringRef RecordType {get;}

        public StringRef Identifier {get;}


        [MethodImpl(Inline)]
        public TableId(Type shape)
        {
            RecordType = shape.Name;
            Identifier = shape.Name;
        }

        [MethodImpl(Inline)]
        public TableId(CliArtifactKey shape, string name)
        {
            RecordType = name;
            Identifier = name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TableId(Type src)
            => Table.id(src);
    }
}