//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Intent is to absorb/transform a process command into a CPS specification
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    /// <typeparam name="R"></typeparam>
    public abstract class ProcessCommandSpec<T, P, R> : CommandSpec<T,R>
        where T : ProcessCommandSpec<T, P, R>, new()
        where P : ProcessCommand<P, R>, new()
        where R : ProcessComandResponse<R, P>

    {
        protected ProcessCommandSpec()
        {
            ProcessCommand = new P();            
        }

        protected ProcessCommandSpec(P ProcessCommand)
            : this()
        {
            this.ProcessCommand = ProcessCommand;
        }

        public P ProcessCommand {get; set;}

        public virtual string Format()
            => ProcessCommand.Format();

        public override string ToString()
            => Format();
    }

    public sealed class ProcessCommandSpec<P,R> : CommandSpec<ProcessCommandSpec<P,R>, R>
        where P : ProcessCommand<P,R>, new()
        where R : ProcessComandResponse<R,P>
    {
        public ProcessCommandSpec()
        {
            ProcessCommand = new P();
        }

        public ProcessCommandSpec(P ProcessCommand)
        {
            this.ProcessCommand = ProcessCommand;
        }

        public P ProcessCommand { get; set; }

        public string Format()
            => ProcessCommand.Format();

        public override string ToString()
            => Format();
    }
}