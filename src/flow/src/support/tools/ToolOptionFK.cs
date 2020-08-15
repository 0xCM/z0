//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolOption<F,K> : IToolOption<F,K>
        where F : unmanaged, Enum
        where K : unmanaged, Enum
    {        
        public F Flag {get;}

        public K Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(F flag, K value)
        {
            Flag = flag;
            Value = value;
        }
    }
}