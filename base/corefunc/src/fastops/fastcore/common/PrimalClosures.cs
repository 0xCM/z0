//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Applies to a generic type/method to advertise the primal types over which the type parameter(s) may be closed
    /// </summary>
    public class PrimalClosuresAttribute : Attribute
    {
        public PrimalClosuresAttribute(PrimalKind system)
        {
            this.SystemPrimitive = system;
            this.UserPrimitive = UserPrimitiveKind.None;
        }

        public PrimalClosuresAttribute(UserPrimitiveKind user)
        {
            this.SystemPrimitive = PrimalKind.None;
            this.UserPrimitive = user;
        }

        public PrimalClosuresAttribute(PrimalKind system, UserPrimitiveKind user)
        {
            this.SystemPrimitive = system;
            this.UserPrimitive = user;
        }

        public PrimalKind SystemPrimitive {get;}

        public UserPrimitiveKind UserPrimitive{get;}         
    }
}