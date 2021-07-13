//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    public abstract class StateMachine<S,T> : IDisposable
    {
        protected S State;

        protected StateMachine(S state)
        {
            State = state;
        }

        public void Dispose()
        {

        }

        protected virtual void Disposing()
        {

        }

        public abstract void Accept(ReadOnlySpan<T> src);

        public abstract ReadOnlySpan<T> Reveal();
    }


    public abstract class StateMachine<S> : StateMachine<S,byte>
    {
        protected StateMachine(S state)
            : base(state)
        {

        }
    }


    public readonly struct StateMachines
    {


    }
}