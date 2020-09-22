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

    partial class PeTableReader
    {
       [MethodImpl(Inline), Op]
       public static Handle handle(ClrArtifactKey token)
            => MetadataTokens.Handle((int)token);
    }
}