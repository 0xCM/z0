//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    public readonly struct TableId : ITextual
    {
        public readonly ApiArtifactKey Shape;

        public readonly CharBlock32 Name;

        [MethodImpl(Inline)]
        public static implicit operator TableId((ApiArtifactKey shape, string name) src)
            => new TableId(src.shape,src.name);

        [MethodImpl(Inline)]
        public static implicit operator TableId(Type src)
            => new TableId(src);

        [MethodImpl(Inline)]
        public TableId(Type shape)
        {
            Shape = shape;
            Name = StorageBlocks.init(shape.Name, CharBlock32.Empty, out Name);
        }

        [MethodImpl(Inline)]
        public TableId(ApiArtifactKey shape, string name)
        {
            Shape = shape;
            Name = StorageBlocks.init(name, CharBlock32.Empty, out Name);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, Shape, StorageBlocks.format(Name));

        public override string ToString()
            => Format();
    }
}