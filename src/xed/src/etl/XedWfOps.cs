//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("api")]
    public readonly partial struct XedWfOps
    {
        [Op]
        public static FS.FileName TargetRuleFile(FS.FileName src, string name)
            => FS.file(text.format("{0}.{1}.{2}.{3}", "xed", "rules", src.WithoutExtension, name), ArchiveFileKinds.Csv);
    }
}