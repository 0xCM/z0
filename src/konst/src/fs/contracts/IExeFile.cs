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
        public interface IExeFile : IFileModule
        {
            FileExt IFileModule.Ext 
                => FS.Extensions.Exe;
        }

        public interface IExeFile<T> : IExeFile
            where T : struct, IExeFile<T>
        {
            
        }
    }
}