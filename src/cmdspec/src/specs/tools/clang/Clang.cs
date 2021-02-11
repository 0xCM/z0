//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public partial class Clang : ToolCmdBuilder<Clang>
    {
        const string DefaultPrefix = "--";

        const PathSeparator DefaultSep = PathSeparator.FS;

        public Clang()
            : base(FS.path("clang.exe"))
        {
            Args = memory.alloc<ToolCmdArg>(256);
            ToolPath = FS.path("clang.exe");
        }

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public Clang config_system_dir(FS.FolderPath value)
            => AppendArg(DefaultPrefix, "config-system-dir", "=", value.Format(DefaultSep));

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public Clang config_user_dir(FS.FolderPath value)
            => AppendArg(DefaultPrefix, "config-user-dir", "=", value.Format(DefaultSep));

        /// <summary>
        /// Specifies configuration file
        /// </summary>
        /// <param name="value">The file path</param>
        public Clang config(FS.FilePath value)
            => AppendArg(DefaultPrefix, "config", Space, value.Format(DefaultSep));

        public Clang dependency_dot(FS.FilePath value)
            => AppendArg(DefaultPrefix, "dependency-dot", Space, value.Format(DefaultSep));

        /// <summary>
        /// Use the LLVM representation for assembler and object files
        /// </summary>
        public Clang emit_llvm()
            => AppendArg(DefaultPrefix, "emit-llvm");

        /// <summary>
        /// Emit Clang AST files for source inputs
        /// </summary>
        public Clang emit_ast()
            => AppendArg(DefaultPrefix, "emit-ast");

        /// <summary>
        /// Enable full Microsoft Visual C++ compatibility
        /// </summary>
        public Clang fms_compatibility()
            => AppendArg(DefaultPrefix, "fms-compatibility");

        public Clang output(FS.FilePath value)
            => AppendArg(DefaultPrefix, "o", Space, value.Format(DefaultSep));

        public Clang print_target_triple()
            => AppendArg(DefaultPrefix, "print-target-triple");

        public Clang print_effective_triple()
            => AppendArg(DefaultPrefix, "print-effective-triple");

        public Clang print_targets()
            => AppendArg(DefaultPrefix, "print-targets");
    }
}