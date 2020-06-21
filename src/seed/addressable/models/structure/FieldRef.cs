//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    
    using static Konst;

    public readonly struct FieldRef
    {
        public MemRef Location {get;}

        public FieldInfo Field {get;}

        [MethodImpl(Inline)]
        public static implicit operator FieldRef((FieldInfo field, MemRef location) src)
            => new FieldRef(src.field, src.location);

        [MethodImpl(Inline)]
        public FieldRef(FieldInfo field, in MemRef location)
        {
            Field = field;
            Location = location;
        }

        public ref readonly char C16
        {
            [MethodImpl(Inline)]
            get => ref Location.Address.Ref<char>();
        }

        public ref readonly byte U8
        {
            [MethodImpl(Inline)]
            get => ref Location.Address.Ref<byte>();
        }
    }
}