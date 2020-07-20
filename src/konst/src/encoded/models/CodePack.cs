//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;        

    public readonly struct CodePack
    {   
        readonly Vector256<byte> Data;

        public CodePack(byte[] src)
        {
            Data = default;
        }
    }
}