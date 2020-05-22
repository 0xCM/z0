//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IProcessState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        object Evolved {get;}

        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(ICommand cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        Seq<ICommand> Processed {get;}
    }

    public interface IProcessState<S> : IProcessState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        new S Evolved {get;}

        object IProcessState.Evolved 
            => Evolved;
    }

    public interface IProcessState<C,S> : IProcessState<S>
        where C : unmanaged, ICommand
    {
        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(in C cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        new Seq<C> Processed {get;}

        Seq<ICommand> IProcessState.Processed 
            => from c in Processed select c as ICommand;

        void IProcessState.Handled(ICommand cmd) 
            => Handled((C)cmd);
    }
}