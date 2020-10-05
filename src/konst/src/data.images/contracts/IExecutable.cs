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
        public interface IExecutable : IFileModule
        {
            FileModuleKind IFileModule.Kind => FileModuleKind.Exe;
        }

        public interface IExecutable<T> : IExecutable
            where T : struct, IExecutable<T>
        {

        }
    }
}