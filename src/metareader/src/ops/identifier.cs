//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        [MethodImpl(Inline), Op]
        public static ApiArtifactKey identifier(in ReaderState state, EntityHandle src)
            => MetadataTokens.GetToken(state.Reader, src);


        [MethodImpl(Inline), Op]
        public static ApiArtifactKey identifier(Handle src)
            => MetadataTokens.GetToken(src);


        [MethodImpl(Inline), Op]
        public static ApiArtifactKey identifier(in ReaderState state, Handle handle)
            => MetadataTokens.GetToken(state.Reader, handle);
    }
}