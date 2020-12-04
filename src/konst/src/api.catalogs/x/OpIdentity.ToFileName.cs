//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XApiIdentity
    {
        [Op]
        public static FileName ToFileName(this OpIdentity src, FS.FileExt ext)
            => FS.file(LegalIdentityBuilder.file(src), ext);
    }
}