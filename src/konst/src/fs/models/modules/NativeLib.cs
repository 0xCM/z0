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
        /// Identifies and represents a native static library
        /// </summary>
        public readonly struct NativeLib : IModule<NativeLib>
        {
            public FilePath Path {get;}


            [MethodImpl(Inline)]
            public NativeLib(FilePath path)
            {
                Path = path;
            }

            public ModuleKind Kind
                => ModuleKind.NativeLib;
        }
    }
}