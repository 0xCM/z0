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

        readonly IWfShell Wf;

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public AsmSemanticArchive(IWfShell wf)
        {
            Wf = wf;
            Root = wf.Db().CaptureRoot() + FS.folder("asm.semantic");
        }

        public FS.FolderPath SemanticDir(PartId part)
            => SemanticDirRule(Root, FS.folder(part.Format()));

        public FS.FilePath SemanticPath(ApiHostUri host)
            => SemanticPathRule(Root, host);

        [MethodImpl(Inline), Op]
        static FS.FileName LegalFileNameRule(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        [MethodImpl(Inline), Op]
        static FS.FileName SemanticFileNameRule(ApiHostUri host, FS.FileExt ext)
            => LegalFileNameRule(host,ext);

        [MethodImpl(Inline), Op]
        static FS.FileExt SemanticExtRule()
            => FS.ext("txt");

        [MethodImpl(Inline), Op]
        static FS.FolderPath SemanticDirRule(FS.FolderPath docroot, FS.FolderName folder)
            => docroot + folder;

        [MethodImpl(Inline), Op]
        static FS.FolderPath SemanticDirRule(FS.FolderPath docroot, PartId part)
            => SemanticDirRule(docroot, FS.folder(part.Format()));

        [MethodImpl(Inline), Op]
        static FS.FilePath SemanticPathRule(FS.FolderPath docroot,  ApiHostUri host)
            => SemanticDirRule(docroot, host.Owner) + SemanticFileNameRule(host, SemanticExtRule());
    }
}