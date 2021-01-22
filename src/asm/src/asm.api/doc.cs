//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct asm
    {
        [Op]
        public static AsmDoc doc(FS.FilePath src)
            => AsmDoc.load(src);
    }
}