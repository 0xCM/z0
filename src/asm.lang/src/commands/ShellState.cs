//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiComplete]
    public class ShellState
    {
        FS.FolderPath _SrcDir;

        FS.FolderPath _DstDir;

        ToolBase _ToolBase;

        TableArchive _Tables;

        ToolId _Tool;

        ProjectBase _ProjectBase;

        ProjectId _Project;

        FS.Files _Files;

        [MethodImpl(Inline)]
        public ToolId Tool()
            => _Tool;

        [MethodImpl(Inline)]
        public ToolId Tool(ToolId id)
        {
            _Tool = id;
            return Tool();
        }

        [MethodImpl(Inline)]
        public ProjectId Project()
            => _Project;

        [MethodImpl(Inline)]
        public ToolBase ToolBase()
            => _ToolBase;

        [MethodImpl(Inline)]
        public ToolBase ToolBase(ToolBase src)
        {
            _ToolBase = src;
            return ToolBase();
        }

        [MethodImpl(Inline)]
        public ProjectId Project(ProjectId id)
        {
            _Project = id;
            return Project();
        }

        [MethodImpl(Inline)]
        public ProjectBase Projects()
            => _ProjectBase;

        [MethodImpl(Inline)]
        public ProjectBase ProjectBase(ProjectBase src)
        {
            _ProjectBase = src;
            return Projects();
        }

        [MethodImpl(Inline)]
        public FS.FolderPath SrcDir()
            => _SrcDir;

        [MethodImpl(Inline)]
        public FS.FolderPath OutDir()
            => _DstDir;

        [MethodImpl(Inline)]
        public FS.FolderPath SrcDir(FS.FolderPath value)
        {
            _SrcDir = value;
            return SrcDir();
        }

        [MethodImpl(Inline)]
        public FS.FolderPath OutDir(FS.FolderPath value)
        {
            _DstDir = value;
            return OutDir();
        }

        [MethodImpl(Inline)]
        public FS.Files Files()
            => _Files;

        [MethodImpl(Inline)]
        public FS.Files Files(FS.Files src)
        {
            _Files = src;
            return Files();
        }

        [MethodImpl(Inline)]
        public TableArchive Tables()
            => _Tables;

        [MethodImpl(Inline)]
        public TableArchive Tables(FS.FolderPath root)
        {
            _Tables = TableArchive.create(root);
            return Tables();
        }

        public ShellState()
        {
            _SrcDir = FS.FolderPath.Empty;
            _DstDir = FS.FolderPath.Empty;
            _Tool = default;
            _Files = array<FS.FilePath>();
        }
    }
}