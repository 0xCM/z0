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

        FS.FolderPath LlSrc()
            => Src() + FS.folder(ll);

        FS.FilePath AsmPath(string id)
            => AsmSrc() + FS.file(id, FS.Asm);

        FS.FilePath AsmPath(string syntax, string id)
            => AsmSrc() + FS.folder(syntax) + FS.file(id, FS.Asm);

        FS.FolderPath Analysis()
            => OutDir() + FS.folder("analysis");

        FS.FolderPath DumpOut()
            => OutDir() + FS.folder(dumps);

        FS.FilePath AsmHexPath(string id)
            => HexOutDir() + FS.file(id, FS.Hex);

        FS.FilePath HexArrayPath(string id)
            => HexOutDir() + FS.file(string.Format("{0}.array",id), FS.Hex);

        FS.FilePath ListPath(string id)
            => Lists() + FS.file(id, FS.AsmList);

        FS.FilePath DisasmPath(string id, ToolId tool, FS.FileExt? ext = null)
            => DisasmOut() + FS.file(string.Format("{0}.{1}", id, tool), ext ?? FS.Asm);
   }
}