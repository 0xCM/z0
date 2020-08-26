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

    [ApiHost]
    public partial struct Cil
    {
        public readonly struct Nop : ICilOpCode<Nop>
        {
            public const string Name = "";

            public ILOpCode Id => ILOpCode.Nop;
        }

        public readonly struct Break : ICilOpCode<Break>
        {
            public ILOpCode Id => ILOpCode.Break;
        }
    }
}