//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmWorkerState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        object Evolved {get;}

        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(IAsmOperands cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        Seq<IAsmOperands> Processed {get;}
    }

    public interface IAsmWorkerState<S> : IAsmWorkerState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        new S Evolved {get;}

        object IAsmWorkerState.Evolved
            => Evolved;
    }

    public interface IAsmWorkerState<C,S> : IAsmWorkerState<S>
        where C : unmanaged, IAsmOperands
    {
        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(in C cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        new Seq<C> Processed {get;}

        Seq<IAsmOperands> IAsmWorkerState.Processed
            => from c in Processed select c as IAsmOperands;

        void IAsmWorkerState.Handled(IAsmOperands cmd)
            => Handled((C)cmd);
    }
}