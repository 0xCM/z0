//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using Z0.Asm.Data;

    public interface IProcessState
    {
        /// <summary>
        /// The state effected by the processed commands
        /// </summary>
        object Evolved {get;}

        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(ICmdData cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        Seq<ICmdData> Processed {get;}
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
        where C : unmanaged, ICmdData
    {
        /// <summary>
        /// Invoked by the processor to signal that a command has been processed
        /// </summary>
        void Handled(in C cmd);

        /// <summary>
        /// The commands that effected the current state
        /// </summary>
        new Seq<C> Processed {get;}

        Seq<ICmdData> IProcessState.Processed 
            => from c in Processed select c as ICmdData;

        void IProcessState.Handled(ICmdData cmd) 
            => Handled((C)cmd);
    }
}