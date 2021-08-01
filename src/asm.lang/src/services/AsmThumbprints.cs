//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class AsmThumbprints : AppService<AsmThumbprints>
    {
        public ReadOnlySpan<AsmThumbprint> Load()
            => Wf.AsmEtl().LoadThumbprints(DefaultPath());

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmHostStatement>() + FS.file("thumbprints", FS.Asm);
    }
}