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

    readonly struct ScalarBitLogicOps
    {
        readonly Index<MemberAddress> Members;

        readonly Index<ClrMemberName> MemberNames;

        static MethodInfo[] prepare(MethodInfo[] src)
        {
            var count = src.Length;
            ref readonly var method = ref first(src);
            for(var i=0; i<count; i++)
                ApiJit.jit(skip(method,i));
            return src;
        }

        public static ScalarBitLogicOps init()
            => new ScalarBitLogicOps(prepare(typeof(math).DeclaredStaticMethods()));

        ScalarBitLogicOps(MethodInfo[] src)
        {
            Members = src.Select(MemberAddress.from);
            Array.Sort(Members);
            var count = Members.Length;
            MemberNames = alloc<ClrMemberName>(count);
            ref var name = ref MemberNames.First;
            for(var i=0; i<count; i++)
                seek(name,i) = Members[i].Member.Name;
        }
    }
}