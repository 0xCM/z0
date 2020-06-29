//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    using API = BitFields;

    public ref struct BitField64<I,W>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {
        internal ulong Data;

        internal readonly BitFieldSpec<I,W> Spec;
            
        [MethodImpl(Inline)]
        internal BitField64(in BitFieldSpec<I,W> spec, ulong data)
        {
            Spec = spec;
            Data = data;
        }

        [MethodImpl(Inline)]
        public BitFieldSegment segment(I index)
            => skip(Spec.Segments, Enums.scalar<I,byte>(index));

        public ulong this[I index]
        {
            [MethodImpl(Inline)]
            get => API.extract(segment(index), Data);
            
            [MethodImpl(Inline)]
            set => API.deposit(segment(index), value, ref Data);
        }
    }
}