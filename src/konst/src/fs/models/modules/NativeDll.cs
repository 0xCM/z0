//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Identifies and represents a native module that lacks  an entry point
        /// </summary>
        public readonly struct NativeDll : IModule<NativeDll>
        {
            public FilePath Path {get;}

            public ModuleKind Kind
                => ModuleKind.NativeLib;

            [MethodImpl(Inline)]
            public NativeDll(FilePath path)
            {
                Path = path;
            }
        }
    }
}