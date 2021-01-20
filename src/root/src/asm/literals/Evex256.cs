//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Literals
{
    partial struct OpCodes
    {
        public readonly struct Evex256
        {
            public const string VPSHUFD = "EVEX.256.66.0F.W0 70 /r ib";

        }
    }
}