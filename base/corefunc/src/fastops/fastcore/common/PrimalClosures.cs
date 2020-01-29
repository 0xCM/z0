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
        public PrimalClosuresAttribute(NumericKind system)
        {
            this.NumericPrimitive = system;
            this.UserPrimitive = UserPrimitiveKind.None;
        }

        public PrimalClosuresAttribute(UserPrimitiveKind user)
        {
            this.NumericPrimitive = NumericKind.None;
            this.UserPrimitive = user;
        }

        public PrimalClosuresAttribute(NumericKind system, UserPrimitiveKind user)
        {
            this.NumericPrimitive = system;
            this.UserPrimitive = user;
        }

        public NumericKind NumericPrimitive {get;}

        public UserPrimitiveKind UserPrimitive{get;}         
    }
}