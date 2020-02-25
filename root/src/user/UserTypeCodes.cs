//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public static class UserTypeCodes
    {
        [MethodImpl(Inline)]
        public static UserTypeCode<T> define<S,T>(S source, ulong id, T rep = default)
            where S : ITypeCodeSource
        {
            if(!source.AssignedCodes.Contains(id))
                throw unsupported<T>();
            return new UserTypeCode<T>(id);
        }
    }
}