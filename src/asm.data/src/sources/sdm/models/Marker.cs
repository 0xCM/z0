//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct SdmModels
    {
        public readonly struct Marker
        {
            public string Content {get;}

            [MethodImpl(Inline)]
            public Marker(string src)
            {
                Content = src;
            }

            public byte Length
            {
                [MethodImpl(Inline)]
                get => (byte)Content.Length;
            }

            [MethodImpl(Inline)]
            public static implicit operator Marker(string src)
                => new Marker(src);
        }
    }
}