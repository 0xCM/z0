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

    readonly struct BitLogicOps
    {
        readonly Index<MemberAddress> Members;

        readonly Index<ClrMemberName> MemberNames;

        public static BitLogicOps init()
        {
            var methods = typeof(ScalarBitLogic).DeclaredStaticMethods().Prepare();
            return new BitLogicOps(methods);
        }

        BitLogicOps(MethodInfo[] src)
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