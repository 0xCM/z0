//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;


    using static Konst;

    [ApiHost]
    public readonly struct Calls
    {

        [MethodImpl(Inline), Op]
        public static CallClient client(OpIdentity id, MemoryAddress @base)
            => new CallClient(id,@base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(OpIdentity id, MemoryAddress @base)
            => new CallTarget(id,@base);            

        [MethodImpl(Inline), Op]
        public static Invocation call(CallClient client, ushort callsite, MemoryAddress target)
            => new Invocation(client, callsite, target);


        [MethodImpl(Inline), Op]
        public static Invocation call(OpIdentity clientId, MemoryAddress @base, ushort callsite, MemoryAddress target)
            => new Invocation(clientId, @base, callsite, target);
    }
}