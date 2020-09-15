//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static FileName ToFileName(this OpIdentity src, FileExtension ext)
            => FileName.define(LegalIdentityBuilder.file(src), ext);
    }
}