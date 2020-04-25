//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a shell-parameteric, application path service
    /// </summary>
    /// <typeparam name="S">The shell reification type</typeparam>
    public interface IShellPaths<S> : IAppPaths
        where S : IShell<S>, new()
    {
        PartId IAppPaths.AppId => typeof(S).Assembly.Id();        
    }
    
    /// <summary>
    /// Reifies default implementation of a shell-parametric application path service
    /// </summary>
    /// <typeparam name="S">The shell reification type</typeparam>
    public readonly struct ShellPaths<S> : IShellPaths<S>
        where S : IShell<S>, new()
    {
        [MethodImpl(Inline)]
        internal ShellPaths(FolderPath root)
        {
            this.Root = root;
        }

        public FolderPath Root {get;}
    }
}