//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ArtifactModel;

    public readonly struct RelationAttributes
    {
        readonly TableSpan<RelationAttribute> Data;

        [MethodImpl(Inline)]
        public static implicit operator RelationAttributes(RelationAttribute[] src)
            => new RelationAttributes(src);

        [MethodImpl(Inline)]
        public static implicit operator RelationAttribute[](RelationAttributes src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public RelationAttributes(uint count)
        {
            Data = sys.alloc<RelationAttribute>(count);
        }

        [MethodImpl(Inline)]
        public RelationAttributes(RelationAttribute[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<RelationAttribute> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<RelationAttribute> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref RelationAttribute this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref RelationAttribute this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}