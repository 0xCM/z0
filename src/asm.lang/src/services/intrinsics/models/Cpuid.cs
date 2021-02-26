//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelIntrinsicsModel
    {
        public const string CpuIdElement = "CPUID";

        public struct CpuId : ITextual
        {
            public string Content;

            [MethodImpl(Inline)]
            public CpuId(string src)
            {
                Content = src;
            }

            public string Format()
                => Content;

            public override string ToString()
                => Content;

            [MethodImpl(Inline)]
            public static implicit operator CpuId(string src)
                => new CpuId(src);
        }
    }
}