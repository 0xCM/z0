//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableId : ITextual
    {
        public readonly ClrArtifactKey RecordType;

        public readonly StringRef Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TableId((ClrArtifactKey shape, string name) src)
            => new TableId(src.shape,src.name);

        [MethodImpl(Inline)]
        public static implicit operator TableId(Type src)
            => new TableId(src);

        [MethodImpl(Inline)]
        public TableId(Type shape)
        {
            RecordType = shape;
            Identifier = shape.Name;
        }

        [MethodImpl(Inline)]
        public TableId(ClrArtifactKey shape, string name)
        {
            RecordType = shape;
            Identifier = name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(RecordType, Identifier);

        public override string ToString()
            => Format();
    }
}