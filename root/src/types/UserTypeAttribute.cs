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

    using static Root;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class UserTypeAttribute : Attribute
    {
        public UserTypeAttribute(object id)
        {
            this.UserTypeId = (ulong)Convert.ChangeType(id, typeof(ulong));
        }

        public readonly ulong UserTypeId;
    }

}