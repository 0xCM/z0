//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public ref struct StackMachine<T>
    {
        Span<StackState> State;

        readonly Span<T> Storage;

        public StackMachine(uint capacity)
        {
            Storage = alloc<T>(capacity);
            State = new StackState[1]{new StackState(capacity)};
        }

        public bool Push(T src)
        {
            if(Input < Capacity)
            {
                seek(Storage, Input++) = src;
                Output--;
                return true;
            }
            else
                return false;
        }

        public bool Pop(out T dst)
        {
            if(Output != Capacity)
            {
                dst = skip(Storage, Output++);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        ref uint Input
            => ref first(State).Input;

        ref uint Output
            => ref first(State).Output;

        ref uint Capacity
            => ref first(State).Capacity;

        ref uint Index
            => ref first(State).Index;

        public ref readonly StackState state()
            => ref first(State);
    }
}