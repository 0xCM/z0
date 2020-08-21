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
        public interface IModule
        {
            FilePath Path {get;}

            ModuleKind Kind {get;}
        }

        public interface IModule<T> : IModule
            where T : struct, IModule<T>
        {

        }

        public interface IModule<F,T> : IModule<T>
            where F : struct, IModule<F,T>
            where T : struct, IModule<T>
        {

        }

    }
}