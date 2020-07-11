//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct Encoded
    {

    }

    public readonly struct Archives : TArchives
    {
        public static TArchives Services => default(Archives);

        [MethodImpl(Inline)]
        public static EncodedHexArchive hex(FolderPath root)
            => new EncodedHexArchive(root);
    }    
}