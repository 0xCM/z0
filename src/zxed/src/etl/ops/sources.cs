//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = XedInstructionField;
    using R = XedInstructionRecord;

    partial struct XedOps
    {
        [MethodImpl(Inline), Op]
        public static ListedFiles sources(in XedEtlConfig config)
            => FS.dir(config.SourceRoot.Name).List("*.*", true);
    }
}