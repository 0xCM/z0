//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static FS;

    partial struct FS
    {
        public interface IFileModule 
        {
            FS.FileName Name {get;}

            FS.FileExt Ext {get;}
        }
        
        public interface IManagedModule : IFileModule
        {

        }

        public interface IMixedModule : INativeModule, IManagedModule
        {

        }
    }
}