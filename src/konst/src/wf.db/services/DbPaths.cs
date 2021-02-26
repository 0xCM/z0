//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DbPaths : IDbPaths
    {
        [MethodImpl(Inline)]
        public static IDbPaths create()
            => new DbPaths(Env.create());

        [MethodImpl(Inline)]
        public static IDbPaths create(Env env)
            => new DbPaths(env);

        public FS.FolderPath Root {get;}

        public Env Env {get;}

        [MethodImpl(Inline)]
        public DbPaths(Env env)
        {
            Env = env;
            Root = Env.Db.Value;
        }
    }
}