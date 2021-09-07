//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WsAtoms;

    public interface IAsmWorkspace : IWorkspace
    {
        FS.FolderPath DisasmOut()
            => OutDir() + FS.folder("dis");

        FS.FolderPath Lists()
            => OutDir() + FS.folder(list);

        /// <summary>
        /// Defines a path of the form {Root}/src
        /// </summary>
        FS.FolderPath Src()
            => Root + FS.folder(src);

        FS.FolderPath AsmSrc()
            => Src() + FS.folder(asm);

        FS.FilePath AsmPath(string id)
            => AsmSrc() + FS.file(id, FS.Asm);

        FS.FilePath AsmPath(string syntax, string id)
            => AsmSrc() + FS.folder(syntax) + FS.file(id, FS.Asm);
   }
}