//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ArchiveConfig<T> : ITextual
        where T : struct
    {
        public FS.FolderPath Root;

        public T Options;

        [MethodImpl(Inline)]
        public ArchiveConfig(FolderPath root, T options)
        {
            Root = FS.dir(root.Name);
            Options = options;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("Root:{0}{1}{2}", Root, Eol, Options);

        public override string ToString()
            => Format();
    }
}