//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class IntrinsicsModels
    {
        public struct CpuId : ITextual
        {
            public const string ElementName = "CPUID";

            public string Content;

            [MethodImpl(Inline)]
            public CpuId(string src)
            {
                Content = src;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => text.nonempty(Content);
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