//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Literals
{
    partial struct OpCodes
    {
        public readonly struct Evex128
        {
            public const string VPSHUFD = "EVEX.128.66.0F.W0 70 /r ib";
        }
    }
}