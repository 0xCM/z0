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
        public interface ILibrary : IFileModule
        {

        }        

        public interface IDynamicLib : ILibrary
        {
            FileExt IFileModule.Ext 
                => FS.Extensions.Dll;
        }

        public interface IStaticLib : ILibrary
        {
            FileExt IFileModule.Ext 
                => FS.Extensions.Lib;            
        }
    }
}