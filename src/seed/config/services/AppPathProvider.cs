//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AppPathProvider : IAppPaths
    {    
        [MethodImpl(Inline)]
        public static IAppPaths FromApp<S>(FolderPath root = null)
            where S : IShell<S>, new()
                 => new ShellPaths<S>(root ?? Env.Current.LogDir);
        
        [MethodImpl(Inline)]
        public static IAppPaths Create(PartId id, FolderPath root)
            => new AppPathProvider(id, root);

        [MethodImpl(Inline)]
        AppPathProvider(PartId id, FolderPath root)
        {
            this.AppId = id;
            this.Root = root;
        }

        public PartId AppId {get;}

        public FolderPath Root {get;}
    }

 
}