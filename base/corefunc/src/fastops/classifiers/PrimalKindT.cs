//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct PrimalKind<T> : IPrimalKind<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator PrimalKind(PrimalKind<T> src)
            => src.Classifier;

        [MethodImpl(Inline)]
        public static implicit operator PrimalKind<T>(T src)
            => default;

        public PrimalKind Classifier 
        {
            [MethodImpl(Inline)] 
            get => PrimalType.kind<T>();
        }
    }
}