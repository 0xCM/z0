//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{

    public partial class Clang : ToolCmdBuilder<Clang>
    {
        public Clang()
            : base(ToolNames.clang)
        {

        }

        const string x86_64_triple = "x86_64-pc-windows-msvc";

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public Clang config_system_dir(FS.FolderPath value)
            => AppendArg("config-system-dir", value);

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        public Clang config_user_dir(FS.FolderPath value)
            => AppendArg("config-user-dir", value);

        /// <summary>
        /// Specifies configuration file
        /// </summary>
        /// <param name="value">The file path</param>
        public Clang config(FS.FilePath value)
            => AppendArg("config", value, Space);

        public Clang dependency_dot(FS.FilePath value)
            => AppendArg("dependency-dot", value, Space);

        /// <summary>
        /// Use the LLVM representation for assembler and object files
        /// </summary>
        public Clang emit_llvm()
            => AppendFlag("emit-llvm");

        /// <summary>
        /// Emit Clang AST files for source inputs
        /// </summary>
        public Clang emit_ast()
            => AppendFlag("emit-ast");

        /// <summary>
        /// Enable full Microsoft Visual C++ compatibility
        /// </summary>
        public Clang fms_compatibility()
            => AppendFlag("fms-compatibility");

        public Clang fparse_all_comments()
            => AppendFlag("fparse-all-comments");

        public Clang cc1()
            => AppendFlag("cc1");

        public Clang output(FS.FilePath value)
            => AppendArg("o", value, Space);

        public Clang triple(string name = x86_64_triple)
            => AppendArg("triple", name, Dash);

        public Clang print_target_triple()
            => AppendFlag("print-target-triple");

        public Clang print_effective_triple()
            => AppendFlag("print-effective-triple");

        public Clang print_targets()
            => AppendFlag("print-targets");
    }
}