//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface ICommandProcessorState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        object Evolved {get;}

        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(IOperands cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        Seq<IOperands> Processed {get;}
    }

    public interface ICommandProcessorState<S> : ICommandProcessorState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        new S Evolved {get;}

        object ICommandProcessorState.Evolved 
            => Evolved;
    }

    public interface ICommandProcessorState<C,S> : ICommandProcessorState<S>
        where C : unmanaged, IOperands
    {
        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(in C cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        new Seq<C> Processed {get;}

        Seq<IOperands> ICommandProcessorState.Processed 
            => from c in Processed select c as IOperands;

        void ICommandProcessorState.Handled(IOperands cmd) 
            => Handled((C)cmd);
    }
}