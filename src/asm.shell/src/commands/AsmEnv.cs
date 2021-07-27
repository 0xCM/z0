//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static WsNames;

    public interface IDomainEnv
    {
        Identifier Name {get;}

        ReadOnlySpan<FS.FolderPath> Folders {get;}
    }

    public interface IDomainEnv<T> : IDomainEnv
        where T : IDomainEnv<T>
    {
        Identifier IDomainEnv.Name
            => typeof(T).Name;
    }

    public readonly struct DomainEnv
    {
        public static FS.FolderPath[] folders(IDomainEnv src)
        {
            var methods = src.GetType().Methods().Returns<FS.FolderPath>().WithArity(0).Concrete();
            return methods.Select(m => (FS.FolderPath)m.Invoke(src,null));
        }
    }

    public class AsmEnv : IDomainEnv<AsmEnv>
    {
        public static AsmEnv create(IEnvProvider src)
            => new AsmEnv(src.DevWs().Asm().Root);

        readonly FS.FolderPath Root;

        readonly Index<FS.FolderPath> _Folders;

        internal AsmEnv(FS.FolderPath root)
        {
            Root = root;
            Src().Create();
            Out().Create();
            Logs().Create();
            Obj().Create();
            Exe().Create();
            Bin().Create();
            Listing().Create();
            Dis().Create();
            _Folders = DomainEnv.folders(this);
        }

        public ReadOnlySpan<FS.FolderPath> Folders
        {
            get => _Folders;
        }

        public FS.FolderPath Src()
            => Root + FS.folder(src) + FS.folder(asm);

        public FS.FolderPath Out()
            => Root + FS.folder(output);

        public FS.FolderPath Logs()
            => Root + FS.folder(logs);

        public FS.FolderPath Obj()
            => Root + FS.folder(obj);

        public FS.FolderPath Exe()
            => Root + FS.folder(exe);

        public FS.FolderPath Bin()
            => Root + FS.folder(bin);

        public FS.FolderPath Listing()
            => Root + FS.folder(listing);

        public FS.FolderPath Dis()
            => Root + FS.folder(dis);

        public FS.FilePath Src(string id)
            => Src() + FS.file(id, FS.Asm);

        public FS.FilePath Obj(string id)
            => Obj() + FS.file(id, FS.Obj);

        public FS.FilePath Bin(string id)
            => Bin() + FS.file(id, FS.Bin);

        public FS.FilePath Exe(string id)
            => Exe() + FS.file(id, FS.Exe);

        public FS.FilePath Listing(string id)
            => Exe() + FS.file(id, FS.Asm);
    }
}