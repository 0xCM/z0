//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileModule : IFileModule<FileModule>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind Kind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, FileModuleKind kind)
        {
            Path = src;
            Kind = kind;
        }

        public bool IsManaged
        {
            [MethodImpl(Inline)]
            get => (Kind & FileModuleKind.Managed) != 0;
        }

        public bool IsExe
        {
            [MethodImpl(Inline)]
            get => (Kind & FileModuleKind.Exe) != 0;
        }

        public bool IsDll
        {
            [MethodImpl(Inline)]
            get => (Kind & FileModuleKind.Dll) != 0;
        }

        public bool IsStaticLib
        {
            [MethodImpl(Inline)]
            get => (Kind & FileModuleKind.Lib) != 0;
        }

        public bool IsNative
        {
            [MethodImpl(Inline)]
            get => (Kind & FileModuleKind.Native) != 0;
        }
    }
}