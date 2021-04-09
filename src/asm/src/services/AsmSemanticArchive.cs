//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.AsmSemanticArchive, true)]
    public readonly struct AsmSemanticArchive : ISemanticArchive<AsmSemanticArchive>
    {
        [MethodImpl(Inline), Op]
        public static ISemanticArchive create(IWfRuntime wf)
            => new AsmSemanticArchive(wf);

        readonly IWfRuntime Wf;

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public AsmSemanticArchive(IWfRuntime wf)
        {
            Wf = wf;
            Root = wf.Db().TableRoot() + FS.folder("asm.semantic");
        }

        public FS.FolderPath SemanticDir(PartId part)
            => SemanticDirRule(Root, FS.folder(part.Format()));

        public FS.FilePath SemanticPath(ApiHostUri host)
            => SemanticPathRule(Root, host);

        [MethodImpl(Inline), Op]
        static FS.FileName LegalFileNameRule(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Part.Format(), Chars.Dot, host.Name), ext);

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
            => SemanticDirRule(docroot, host.Part) + SemanticFileNameRule(host, SemanticExtRule());
    }
}