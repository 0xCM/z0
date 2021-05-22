//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CaptureRoot()
            => DbRoot() + FS.folder(capture);

        FS.FolderPath CaptureRoot(FS.FolderPath root)
            => DbRoot(root) + FS.folder(capture);

        FS.FolderPath ImmCaptureRoot()
            => CaptureRoot() + FS.folder(imm);

        FS.FolderPath ImmCaptureRoot(FS.FolderPath root)
            => CaptureRoot(root) + FS.folder(imm);

        FS.FolderPath CaptureContextRoot()
            => CaptureRoot() + FS.folder(context);

        FS.FolderPath CaptureContextRoot(FS.FolderPath root)
            => CaptureRoot(root) + FS.folder(context);

        FS.FolderPath AsmCaptureRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.FolderPath AsmCaptureRoot(FS.FolderPath root)
            => CaptureRoot(root) + FS.folder(asm);

        FS.Files AsmCapturePaths()
            => AsmCaptureRoot().Files(FS.Asm, true);

        FS.Files AsmCapturePaths(FS.FolderPath root)
            => AsmCaptureRoot(root).Files(FS.Asm, true);

        FS.Files AsmCapturePaths(PartId part)
            => AsmCapturePaths().Where(f => f.IsOwner(part));

        FS.Files AsmCapturePaths(FS.FolderPath root, PartId part)
            => AsmCapturePaths(root).Where(f => f.IsOwner(part));

        FS.FilePath AsmCapturePath(ApiHostUri host)
            => AsmCaptureRoot() + PartFolder(host.Part) + ApiFiles.filename(host, FS.Asm);

        FS.FilePath AsmCapturePath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) +  ApiFiles.filename(host, FS.Asm);

        FS.FilePath AsmCapturePath(PartId part, string api)
            => AsmCaptureRoot() + ApiFileName(part, api, FS.Asm);

        FS.FilePath AsmCapturePath(FS.FolderPath root, PartId part, string api)
            => AsmCaptureRoot(root) + ApiFileName(part, api, FS.Asm);
    }
}