//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cil
    {
        public readonly struct OpCode<K>
            where K : unmanaged, ICilOpCode<K>
        {
            public static implicit operator OpCode<K>(K src)
                => default;

            public ILOpCode Id => default(K).Id;
        }

    }
}