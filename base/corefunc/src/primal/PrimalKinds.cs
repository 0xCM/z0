//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static PrimalKind;

    public static class PrimalKinds
    {
        public static readonly PrimalKind[] AllList = kinds<PrimalKind>();

        public static readonly PrimalKind[] IntList = array(PrimalKind.int8, PrimalKind.uint8, PrimalKind.int16, PrimalKind.uint16, PrimalKind.int32, PrimalKind.uint32, PrimalKind.int64, PrimalKind.uint64);
                
        [MethodImpl(Inline)]
        public static PrimalKind kind<T>()
            => PrimalKind<T>.Kind;

    }
}