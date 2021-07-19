//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class IntrinsicsModels
    {
        public readonly struct CategoryNames
        {
            public const string Convert = "Convert";

            public const string Move = "Move";

            public const string Load = "Load";

            public const string Compare = "Compare";
        }
    }
}