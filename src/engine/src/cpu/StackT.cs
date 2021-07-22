//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct Stack<T>
        where T : unmanaged
    {
        readonly Index<T> Storage;

        uint Pos;

        uint Capacity;

        public Stack(uint capacity)
        {
            Capacity = capacity;
            Storage = alloc<T>(Capacity);
            Pos = (uint)Storage.Length - 1;
        }

        [MethodImpl(Inline)]
        public Stack(T[] buffer)
        {
            Capacity = (uint)buffer.Length - 1;
            Storage = buffer;
            Pos = (uint)Storage.Length - 1;
        }

        [MethodImpl(Inline)]
        public bit Pop(out T cell)
        {
            if(Pos < Capacity)
            {
                cell = Storage[Pos++];
                return true;
            }
            else
            {
                cell = default;
                return false;
            }
        }

        [MethodImpl(Inline)]
        public bit Push(in T cell)
        {
            if(Pos > 0)
            {
                Storage[Pos--] = cell;
                return true;
            }
            else
                return true;
        }
    }
}