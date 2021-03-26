//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TableId : ITableId
    {
        public Name RecordType {get;}

        public Name Identifier {get;}

        [MethodImpl(Inline)]
        public TableId(Type shape, string name)
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
            => RecUtil.tableid(src);
    }
}