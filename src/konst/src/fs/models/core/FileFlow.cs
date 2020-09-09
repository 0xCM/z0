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
        /// Defines a data flow from one path to another
        /// </summary>
        public readonly struct FileFlow : IDataFlow<FilePath>
        {
            public FilePath Source {get;}

            public FilePath Target {get;}

            [MethodImpl(Inline)]
            public static implicit operator FileFlow((FilePath src, FilePath dst) x)
                => new FileFlow(x.src, x.dst);

            [MethodImpl(Inline)]
            public FileFlow(FilePath src, FilePath dst)
            {
                Source = src;
                Target = dst;
            }
        }
    }
}