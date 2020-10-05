//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public interface IModuleArchive : IFileArchive<ModuleArchive,FileModule>
    {
        void Query(Receiver<ManagedDll> dst);

        void Query(Receiver<NativeDll> dst);

        void Query(Receiver<ManagedExe> dst);

        void Query(Receiver<NativeLib> dst);
    }
}