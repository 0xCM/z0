//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ModelIdentity : IModelIdentity
    {
        public BinaryCode Identifier {get;}

        [MethodImpl(Inline)]
        public static implicit operator ModelIdentity(BinaryCode src)
            => new ModelIdentity(src);

        [MethodImpl(Inline)]
        public static implicit operator ModelIdentity(byte[] src)
            => new ModelIdentity(src);

        [MethodImpl(Inline)]
        public ModelIdentity(BinaryCode src)
            => Identifier = src;
    }
}