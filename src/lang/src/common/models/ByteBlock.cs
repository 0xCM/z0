//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ByteBlock
    {
        public ByteSize Length {get;}
    }

    public readonly struct ByteBlockValue
    {
        public byte[] Content {get;}

        public ByteBlockValue(byte[] content)
        {
            Content = content;
        }
    }
}