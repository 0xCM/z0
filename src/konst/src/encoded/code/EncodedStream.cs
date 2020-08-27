//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.IO;

    using static Konst;

    public readonly struct EncodedStream : IDisposable
    {
        readonly BinaryCode Store;

        readonly MemoryStream Stream;

        [MethodImpl(Inline)]
        public EncodedStream(BinaryCode src)
        {
            Store = src;
            Stream =  new MemoryStream(src.Encoded);
        }

        public void Dispose()
        {
            Stream?.Dispose();
        }
    }
}