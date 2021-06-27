//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents a managed or native image
    /// </summary>
    public readonly struct FileModule : IFileModule<FileModule>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind ModuleKind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, FileModuleKind kind)
        {
            Path = src;
            ModuleKind = kind;
        }

        public bool IsManaged
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & FileModuleKind.Managed) != 0;
        }

        public bool IsExe
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & FileModuleKind.Exe) != 0;
        }

        public bool IsDll
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & FileModuleKind.Dll) != 0;
        }

        public bool IsStaticLib
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & FileModuleKind.Lib) != 0;
        }

        public bool IsNative
        {
            [MethodImpl(Inline)]
            get => (ModuleKind & FileModuleKind.Native) != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator ImagePath(FileModule src)
            => src.Path;
    }
}