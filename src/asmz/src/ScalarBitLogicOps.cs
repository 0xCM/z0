//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;


    readonly struct MathOps
    {
        public static MathOps init()
            => new MathOps(ApiJit.jit(typeof(math).DeclaredStaticMethods()));

        readonly Index<MemberAddress> Addresses;

        readonly Index<ClrMemberName> Names;

        MathOps(Index<MemberAddress> src)
        {
            Addresses = src;
            Array.Sort(Addresses);
            var count = Addresses.Length;
            Names = alloc<ClrMemberName>(count);
            ref var name = ref Names.First;
            for(var i=0; i<count; i++)
                seek(name,i) = Addresses[i].Member.Name;
        }
    }
}