//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Archives : IArchiveServices
    {
        public static IArchiveServices Services => default(Archives);

        [MethodImpl(Inline)]
        public static EncodedHexArchive hex(FolderPath root)
            => new EncodedHexArchive(root);
    }    
}