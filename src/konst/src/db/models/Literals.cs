//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct DbSvc
    {
        public const string dot = AsciCharText.Dot;

        public readonly struct Literals
        {
            public const string asm = nameof(asm);

            public const string cs = nameof(cs);
        }
    }
}