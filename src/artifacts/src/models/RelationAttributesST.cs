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

    public readonly struct RelationAttributes<S,T>
    {
        readonly TableSpan<RelationAttribute<S,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator RelationAttributes<S,T>(RelationAttribute<S,T>[] src)
            => new RelationAttributes<S,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator RelationAttribute<S,T>[](RelationAttributes<S,T> src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public RelationAttributes(uint count)
        {
            Data = sys.alloc<RelationAttribute<S,T>>(count);
        }

        [MethodImpl(Inline)]
        public RelationAttributes(RelationAttribute<S,T>[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<RelationAttribute<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<RelationAttribute<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref RelationAttribute<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref RelationAttribute<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}