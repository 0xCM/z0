//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.AsmSemanticArchive, true)]
    public readonly struct AsmSemanticArchive : ISemanticArchive<AsmSemanticArchive>
    {
        [MethodImpl(Inline), Op]
        public static ISemanticArchive create(IWfShell wf)
            => new AsmSemanticArchive(wf);

        [MethodImpl(Inline), Op]
        public static FS.FileName LegalFileNameRule(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        [MethodImpl(Inline), Op]
        public static FS.FileName SemanticFileNameRule(ApiHostUri host, FS.FileExt ext)
            => LegalFileNameRule(host,ext);

        [MethodImpl(Inline), Op]
        public static FS.FolderName SemanticFolderRule()
            => FS.folder("asm.semantic");

        [MethodImpl(Inline), Op]
        public static FS.FileExt SemanticExtRule()
            => FS.ext("txt");

        [MethodImpl(Inline), Op]
        public static FS.FolderPath SemanticDirRule(FS.FolderPath docroot, FS.FolderName folder)
            => docroot + SemanticFolderRule() + folder;

        [MethodImpl(Inline), Op]
        public static FS.FolderPath SemanticDirRule(FS.FolderPath docroot, PartId part)
            => SemanticDirRule(docroot, FS.folder(part.Format()));

        [MethodImpl(Inline), Op]
        public static FS.FilePath SemanticPathRule(FS.FolderPath docroot,  ApiHostUri host)
            => SemanticDirRule(docroot, host.Owner) + SemanticFileNameRule(host, SemanticExtRule());

        readonly IWfShell Wf;

        public IDbPaths DbPaths {get;}

        readonly FS.FolderPath SemanticRoot;

        [MethodImpl(Inline)]
        public AsmSemanticArchive(IWfShell wf)
        {
            Wf = wf;
            DbPaths = Z0.DbPaths.create(wf);
            SemanticRoot = DbPaths.DocRoot();
        }

        public FS.FolderName SemanticFolder
            => SemanticFolderRule();

        public FS.FileExt SemanticExt
            => SemanticExtRule();

        public FS.FolderPath SemanticDir(FS.FolderName folder)
            => SemanticDirRule(SemanticRoot, folder);

        public FS.FolderPath SemanticDir(PartId part)
            => SemanticDirRule(SemanticRoot, FS.folder(part.Format()));

        public FS.FileName SemanticFileName(ApiHostUri host, FS.FileExt ext)
            => SemanticFileNameRule(host, ext);

        public FS.FilePath SemanticPath(ApiHostUri host)
            => SemanticPathRule(SemanticRoot, host);
    }
}