//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    partial class XApi
    {
        [Op]
        public static FileName ToFileName(this OpIdentity src, FS.FileExt ext)
            => FS.file(LegalIdentityBuilder.file(src), ext);
    }
}