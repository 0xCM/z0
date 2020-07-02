//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkState
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

    public interface IWorkState<S> : IWorkState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        new S Evolved {get;}

        object IWorkState.Evolved 
            => Evolved;
    }

    public interface IWorkState<C,S> : IWorkState<S>
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

        Seq<IOperands> IWorkState.Processed 
            => from c in Processed select c as IOperands;

        void IWorkState.Handled(IOperands cmd) 
            => Handled((C)cmd);
    }
}