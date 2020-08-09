//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    public interface IMonitor : IDisposable
    {
        void Start();

        void Stop();
    }
    
    public interface IMonitor<T> : IMonitor
    {
        T Subject {get;}        
    }

    public interface IDirectoryMonitor : IMonitor<FolderPath>
    {
        
    }
}