//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiSig : IApiSig
    {
        readonly BinaryCode Data;

        [MethodImpl(Inline)]
        internal ApiSig(BinaryCode src)
            => Data = src;

        public string Format()
            => Data.Format();


        public override string ToString()
            => Format();
    }
}