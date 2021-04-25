//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiComplete]
    public readonly ref struct StackMachine
    {
        readonly Span<StackState> State;

        readonly Span<ulong> Storage;

        public StackMachine(uint capacity)
        {
            Storage = alloc<ulong>(capacity);
            State = new StackState[1]{new StackState(capacity)};
        }

        [MethodImpl(Inline)]
        public bool Push(ulong src)
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

        [MethodImpl(Inline)]
        public bool Pop(out ulong dst)
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
        {
            [MethodImpl(Inline)]
            get => ref first(State).Input;
        }

        ref uint Output
        {
            [MethodImpl(Inline)]
            get => ref first(State).Output;
        }

        ref uint Capacity
        {
            [MethodImpl(Inline)]
            get => ref first(State).Capacity;
        }

        ref uint Index
        {
            [MethodImpl(Inline)]
            get => ref first(State).Index;
        }

        [MethodImpl(Inline)]
        public ref readonly StackState state()
            => ref first(State);
    }
}