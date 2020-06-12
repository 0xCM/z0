//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;

    using Z0.Asm;

    public interface IProcessState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        object Evolved {get;}

        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(ICmd cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        Seq<ICmd> Processed {get;}
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
        where C : unmanaged, ICmd
    {
        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(in C cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        new Seq<C> Processed {get;}

        Seq<ICmd> IProcessState.Processed 
            => from c in Processed select c as ICmd;

        void IProcessState.Handled(ICmd cmd) 
            => Handled((C)cmd);
    }
}