//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct FormalModels
    {
        const NumericKind Closure = Integers;

        [ApiHost("models.circuits")]
        public readonly partial struct Circuits
        {

        }
    }
}