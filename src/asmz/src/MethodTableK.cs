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

    public readonly struct MethodTable<T>
    {
        [MethodImpl(Inline)]
        public static MethodTable<T> create()
            => new MethodTable<T>(typeof(T));

        public Type Type {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        MethodTable(Type src)
        {
            Type = src;
            Address = src.TypeHandle.Value;
        }

        [MethodImpl(Inline)]
        public static implicit operator MethodTable(MethodTable<T> src)
            => src.Type;
    }
}