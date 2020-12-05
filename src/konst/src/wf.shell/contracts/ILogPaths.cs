//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ILogPaths
    {
        /// <summary>
        /// The global application log root
        /// </summary>
        FS.FolderPath LogRoot {get;}

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }

    [Free]
    public interface ILogPaths<A> : ILogPaths
    {

    }
}