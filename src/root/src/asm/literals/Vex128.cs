//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Literals
{
    partial struct OpCodes
    {
        public readonly struct Vex128
        {
            public const string VPSHUFD = "VEX.128.66.0F.WIG 70 /r ib";
        }

    }
}