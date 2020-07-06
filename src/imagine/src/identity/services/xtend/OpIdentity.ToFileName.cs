//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class XTend
    {
        public static FileName ToFileName(this OpIdentity src, FileExtension ext)
            => FileName.Define(LegalIdentityBuilder.file(src), ext);        
    }
}