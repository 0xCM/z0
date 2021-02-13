//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public partial class clang : ToolCmdBuilder<clang>
    {
        public clang()
            : base(nameof(clang).ToLower())
        {

        }

        const string x86_64_triple = "x86_64-pc-windows-msvc";

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public clang config_system_dir(FS.FolderPath value)
            => AppendArg("config-system-dir", value);

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public clang config_user_dir(FS.FolderPath value)
            => AppendArg("config-user-dir", value);

        /// <summary>
        /// Specifies configuration file
        /// </summary>
        /// <param name="value">The file path</param>
        public clang config(FS.FilePath value)
            => AppendArg("config", value, Space);

        public clang dependency_dot(FS.FilePath value)
            => AppendArg("dependency-dot", value, Space);

        /// <summary>
        /// Use the LLVM representation for assembler and object files
        /// </summary>
        public clang emit_llvm()
            => AppendFlag("emit-llvm");

        /// <summary>
        /// Emit Clang AST files for source inputs
        /// </summary>
        public clang emit_ast()
            => AppendFlag("emit-ast");

        /// <summary>
        /// Enable full Microsoft Visual C++ compatibility
        /// </summary>
        public clang fms_compatibility()
            => AppendFlag("fms-compatibility");

        public clang fparse_all_comments()
            => AppendFlag("fparse-all-comments");

        public clang cc1()
            => AppendFlag("cc1");

        public clang output(FS.FilePath value)
            => AppendArg("o", value, Space);

        public clang triple(string name = x86_64_triple)
            => AppendArg("triple", name, Dash);

        public clang print_target_triple()
            => AppendFlag("print-target-triple");

        public clang print_effective_triple()
            => AppendFlag("print-effective-triple");

        public clang print_targets()
            => AppendFlag("print-targets");
    }
}