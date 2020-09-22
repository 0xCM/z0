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

    public readonly struct TableId<T>
        where T : struct
    {
        public static TableId<T> Value => default;

        public static Type TableType => typeof(T);

        public ApiArtifactKey Shape => TableType;

        public CharBlock32 Name => TableType.Name;

        public static implicit operator TableId(TableId<T> src)
            => TableType;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, Shape, StorageBlocks.format(Name));
    }
}