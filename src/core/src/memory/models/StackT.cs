//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Stack<T>
    {
        readonly Index<T> Storage;

        uint Pos;

        uint Capacity;

        public Stack(uint capacity)
        {
            Capacity = capacity;
            Storage = sys.alloc<T>(Capacity);
            Pos = (uint)Storage.Length - 1;
        }

        [MethodImpl(Inline)]
        public Stack(T[] buffer)
        {
            Capacity = (uint)buffer.Length;
            Storage = buffer;
            Pos = (uint)Storage.Length - 1;
        }

        [MethodImpl(Inline)]
        public bool Pop(out T cell)
        {
            if(Pos < Capacity - 1)
            {
                cell = Storage[++Pos];
                return true;
            }
            else
            {
                cell = default;
                return false;
            }
        }

        [MethodImpl(Inline)]
        public bool Push(in T cell)
        {
            if(Pos > 0)
            {
                Storage[Pos--] = cell;
                return true;
            }
            else
                return false;
        }
    }
}