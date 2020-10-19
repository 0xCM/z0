//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface IExtensionMap<F> : ITextual
        where F : unmanaged, Enum
    {
        ReadOnlySpan<FileExtension> Extensions {get;}

        ReadOnlySpan<F> Flags {get;}

        void MapExtension(F flag, FileExtension ext);

        FileExtension Ext(F f);   
    }
}