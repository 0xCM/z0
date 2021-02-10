//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IToolCmdBuilder : IWfService
    {

    }

    public abstract class ToolCmdBuilder<T> : WfService<T,IToolCmdBuilder>, IToolCmdBuilder
        where T : ToolCmdBuilder<T>, new()
    {

    }

    [ApiHost]
    public partial class Clang : WfService<Clang,Clang>
    {
        Index<ToolCmdArg> Args;

        uint Index;

        FS.FilePath ToolPath;

        const string DefaultPrefix = "--";

        const PathSeparator DefaultSep = PathSeparator.FS;

        public Clang()
        {
            Args = memory.alloc<ToolCmdArg>(256);
            Index = 0;
            ToolPath = FS.path("clang.exe");
        }

        [MethodImpl(Inline)]
        protected ToolCmdSpec CreateSpec()
            => Cmd.toolcmd(ToolPath, Args);

        [Op]
        public ToolCmdSpec Emit(bool clear = true)
        {
            var spec = CreateSpec();
            if(clear)
            {
                Args.Clear();
                Index = 0;
            }
            return spec;
        }

        [Op]
        public string Format()
            => CreateSpec().Format();

        [MethodImpl(Inline), Op]
        protected Clang AppendArg(string content)
        {
            Args[Index++] = content;
            return this;
        }

        [MethodImpl(Inline), Op]
        protected Clang AppendArg(dynamic a, dynamic b)
            => AppendArg(text.adjacent(a,b));

        [MethodImpl(Inline), Op]
        protected Clang AppendArg(dynamic a, dynamic b, dynamic c)
            => AppendArg(text.adjacent(a, b, c));

        [MethodImpl(Inline), Op]
        protected Clang AppendArg(dynamic a, dynamic b, dynamic c, dynamic d)
            => AppendArg(text.adjacent(a, b, c, d));

        [MethodImpl(Inline), Op]
        protected Clang AppendArg(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e)
            => AppendArg(text.adjacent(a, b, c, d, e));

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        [Op]
        public Clang config_system_dir(FS.FolderPath value)
            => AppendArg(DefaultPrefix, "config-system-dir", "=", value.Format(DefaultSep));

        /// <summary>
        /// System directory for configuration files
        /// </summary>
        /// <param name="value">The directory path</param>
        [Op]
        public Clang config_user_dir(FS.FolderPath value)
            => AppendArg(DefaultPrefix, "config-user-dir", "=", value.Format(DefaultSep));

        /// <summary>
        /// Specifies configuration file
        /// </summary>
        /// <param name="value">The file path</param>
        [Op]
        public Clang config(FS.FilePath value)
            => AppendArg(DefaultPrefix, "config", Space, value.Format(DefaultSep));

        [Op]
        public Clang dependency_dot(FS.FilePath value)
            => AppendArg(DefaultPrefix, "dependency-dot", Space, value.Format(DefaultSep));

        [Op]
        public Clang output(FS.FilePath value)
            => AppendArg(DefaultPrefix, "o", Space, value.Format(DefaultSep));

        [Op]
        public Clang print_target_triple()
            => AppendArg(DefaultPrefix, "print-target-triple");

        [Op]
        public Clang print_effective_triple()
            => AppendArg(DefaultPrefix, "print-effective-triple");

        [Op]
        public Clang print_targets()
            => AppendArg(DefaultPrefix, "print-targets");
    }
}