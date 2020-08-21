//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Konst;

    partial struct FS
    {
        public readonly struct Module<T> : IModule<Module<T>,T>
            where T : struct, IModule<T>
        {
            public FilePath Path {get;}

            public ModuleKind Kind {get;}

            [MethodImpl(Inline)]
            public Module(FilePath src, ModuleKind kind)
            {
                Path = src;
                Kind = kind;
            }
        }
    }
}