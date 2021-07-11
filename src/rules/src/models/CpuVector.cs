//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Rules
    {
        [StructLayout(LayoutKind.Sequential)]
        public readonly struct CpuVector : IRuleDataType<CpuVector>
        {
            public VectorKind Kind {get;}

            public string Name => Kind.ToString();

            [MethodImpl(Inline)]
            public CpuVector(VectorKind kind)
            {
                Kind = kind;
            }
        }
    }
}