//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    public sealed class AsmThumbprints : AppService<AsmThumbprints>
    {
        public ReadOnlySpan<AsmThumbprint> Load()
            => Wf.AsmEtl().LoadThumbprints(DefaultPath());

        public void ShowThumprints()
        {
            var src = Load();
            var count = src.Length;
            using var log = ShowLog(FS.Asm, "thumbprints");
            for(var i=0; i<count; i++)
                log.Show(AsmRender.format(skip(src,i)));
        }

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmHostStatement>() + FS.file("thumbprints", FS.Asm);
    }
}