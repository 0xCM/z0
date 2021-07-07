//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public ref struct CallVector
    {
        public ReadOnlySpan<byte> Context;

        public ReadOnlySpan<byte> Target;

        public ReadOnlySpan<byte> OperandValues;

    }
}