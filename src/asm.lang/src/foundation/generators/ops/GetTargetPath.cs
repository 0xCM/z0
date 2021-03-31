//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;

    partial class AsmGen
    {
        FS.FilePath GetTargetPath(AsmGenTarget kind)
            => Db.SourceFile(PartId.AsmLangG, FS.file(TargetIdentifier(kind).Format(), FS.Cs));


        FS.FilePath GetTargetPath(AsmGenTarget kind, FS.FolderPath dst)
            => dst + FS.file(TargetIdentifier(kind).Format(), FS.Cs);

    }
}