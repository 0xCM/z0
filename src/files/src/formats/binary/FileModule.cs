//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileModule : IFileModule<FileModule>
    {
        public FS.FilePath Path {get;}

        public BinaryModuleKind ModuleKind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, BinaryModuleKind kind)
        {
            Path = src;
            ModuleKind = kind;
        }

        public bool IsManaged
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & BinaryModuleKind.Managed) != 0;
        }

        public bool IsExe
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & BinaryModuleKind.Exe) != 0;
        }

        public bool IsDll
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & BinaryModuleKind.Dll) != 0;
        }

        public bool IsStaticLib
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & BinaryModuleKind.Lib) != 0;
        }

        public bool IsNative
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & BinaryModuleKind.Native) != 0;
        }
    }
}