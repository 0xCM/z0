//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IToolCmdBuilder : IWfService, ITextual
    {
        ToolCmdSpec Emit(bool clear = true);
    }

    public abstract class ToolCmdBuilder<T> : WfService<T,IToolCmdBuilder>, IToolCmdBuilder
        where T : ToolCmdBuilder<T>, new()
    {

        const string DefaultPrefix = "--";

        const PathSeparator DefaultSep = PathSeparator.FS;

        protected Index<ToolCmdArg> Args;

        uint Index;

        protected FS.FilePath ToolPath;

        public ToolCmdBuilder(FS.FilePath tool)
        {
            Args = memory.alloc<ToolCmdArg>(256);
            Index = 0;
            ToolPath = FS.path("clang.exe");
        }

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

        protected ToolCmdSpec CreateSpec()
            => Cmd.toolcmd(ToolPath, Args);

        [MethodImpl(Inline)]
        protected T AppendArg(string content)
        {
            Args[Index++] = content;
            return (T)this;
        }

        protected T AppendArg(dynamic a, dynamic b)
            => AppendArg(text.adjacent(a,b));

        protected T AppendArg(dynamic a, dynamic b, dynamic c)
            => AppendArg(text.adjacent(a, b, c));

        protected T AppendArg(dynamic a, dynamic b, dynamic c, dynamic d)
            => AppendArg(text.adjacent(a, b, c, d));

        protected T AppendArg(dynamic a, dynamic b, dynamic c, dynamic d, dynamic e)
            => AppendArg(text.adjacent(a, b, c, d, e));

        public string Format()
            => CreateSpec().Format();
    }
}