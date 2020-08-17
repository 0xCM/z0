//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileSystemObjects
    {
        public readonly FileSystemObject Root;

        readonly FileSystemObject[] Data;

        [MethodImpl(Inline)]
        public FileSystemObjects(FileSystemObject root, FileSystemObject[] objects)
        {
            Root = root;
            Data = objects;
        }

        public ReadOnlySpan<FileSystemObject> Objects
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}