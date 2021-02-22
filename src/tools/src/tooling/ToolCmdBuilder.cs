//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
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
        protected Index<CmdArg> Args;

        ushort Index;

        protected FS.FileName ToolName;

        public ToolCmdBuilder(Name tool)
        {
            Args = memory.alloc<CmdArg>(256);
            Index = 0;
            ToolName = FS.file(tool.Format(), FileExtensions.Exe);
        }

        protected virtual PathSeparator PathSeparator => PathSeparator.FS;

        protected ArgPrefix Dash => ArgPrefix.Dash;

        protected ArgPrefix DoubleDash => ArgPrefix.DoubleDash;

        protected ArgPrefix Slash => ArgPrefix.FSlash;

        protected ArgQualifier Space => ArgQualifier.Space;

        protected ArgQualifier Colon => ArgQualifier.Colon;

        protected ArgQualifier Eq => ArgQualifier.Eq;

        protected virtual ArgPrefix DefaultPrefix => DoubleDash;

        protected virtual ArgQualifier DefaultQualifier => Eq;

        protected virtual bool QuotePaths => true;

        protected virtual FS.FolderPath ToolDir => FS.FolderPath.Empty;

        protected FS.FilePath ToolPath => ToolDir + ToolName;

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
        protected T AppendFlag<A>(A value)
        {
            Args[Index] = Cmd.flag(Index, value, Dash);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendFlag<A>(A value, ArgPrefix prefix)
        {
            Args[Index] = Cmd.flag(Index, value, prefix);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendFlag<A>(string name, A value, ArgPrefix prefix)
        {
            Args[Index] = Cmd.flag(Index, name, value, prefix);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendFlag<A>(string name, A value)
        {
            Args[Index] = Cmd.flag(Index, name, value, DefaultPrefix);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg<A>(string name, A value)
        {
            Args[Index] = Cmd.arg(Index, name, value, DefaultPrefix, DefaultQualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg<A>(string name, A value, ArgPrefix prefix)
        {
            Args[Index] = Cmd.arg(Index, name, value, prefix);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg<A>(string name, A value, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value, DefaultPrefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg<A>(string name, A value, ArgPrefix prefix, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value, prefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FolderPath value, ArgPrefix prefix, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator,QuotePaths), prefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FolderPath value, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator,QuotePaths), DefaultPrefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FolderPath value)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator,QuotePaths), DefaultPrefix, DefaultQualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FilePath value, ArgPrefix prefix, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator, QuotePaths), prefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FilePath value, ArgQualifier qualifier)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator, QuotePaths), DefaultPrefix, qualifier);
            Index++;
            return (T)this;
        }

        [MethodImpl(Inline)]
        protected T AppendArg(string name, FS.FilePath value)
        {
            Args[Index] = Cmd.arg(Index, name, value.Format(PathSeparator, QuotePaths), DefaultPrefix, DefaultQualifier);
            Index++;
            return (T)this;
        }

        public string Format()
            => CreateSpec().Format();
    }
}