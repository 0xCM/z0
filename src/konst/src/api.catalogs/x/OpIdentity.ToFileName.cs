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
        public static FileName ToFileName(this OpIdentity src, FileExtension ext)
            => FileName.define(LegalIdentityBuilder.file(src), ext);
    }
}