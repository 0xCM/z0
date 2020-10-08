//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ApiSurfaces : ITableSpan<ApiSurfaces,ApiSurface>
    {
        readonly TableSpan<ApiSurface> Data;

        [MethodImpl(Inline)]
        public ApiSurfaces(ApiSurface[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiSurfaces(ApiSurface[] src)
            => new ApiSurfaces(src);

        public Span<ApiSurface> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<ApiSurface> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref ApiSurface this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref ApiSurface this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ApiSurface[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public ApiSurfaces Refresh(ApiSurface[] src)
            => new ApiSurfaces(src);
    }
}