//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct CliHandles<T>
        where T : unmanaged
    {
        readonly uint LastRowId;

        uint CurrentRowId;

        public T Current
        {
            [MethodImpl(Inline)]
            get => memory.@as<uint,T>((CurrentRowId & 0xFFFFFFu));
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => LastRowId;
        }

        [MethodImpl(Inline)]
        public CliHandles(uint lastRowId)
        {
            LastRowId = lastRowId;
            CurrentRowId = 0;
        }

        [MethodImpl(Inline)]
        public CliHandles(int lastRowId)
        {
            LastRowId = (uint)lastRowId;
            CurrentRowId = 0;
        }

        [MethodImpl(Inline)]
        public bool MoveNext()
        {
            if (CurrentRowId >= LastRowId)
            {
                CurrentRowId = 16777216;
                return false;
            }
            CurrentRowId++;
            return true;
        }

        [MethodImpl(Inline)]
        public bool Next(out T dst)
        {
            if(MoveNext())
            {
                dst = Current;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }
    }
}