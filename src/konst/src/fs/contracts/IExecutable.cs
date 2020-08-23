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
        public interface IExecutable : IModule
        {
            ModuleKind IModule.Kind => ModuleKind.Exe;
        }

        public interface IExecutable<T> : IExecutable
            where T : struct, IExecutable<T>
        {

        }
    }
}