//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Applies to a generic type/method to advertise the primal types over which the type parameter(s) may be closed
    /// </summary>
    public class NumericClosuresAttribute : Attribute
    {
        public NumericClosuresAttribute(NumericKind system)
        {
            this.NumericPrimitive = system;
            this.UserPrimitive = UserPrimitiveKind.None;
        }

        public NumericClosuresAttribute(UserPrimitiveKind user)
        {
            this.NumericPrimitive = NumericKind.None;
            this.UserPrimitive = user;
        }

        public NumericClosuresAttribute(NumericKind system, UserPrimitiveKind user)
        {
            this.NumericPrimitive = system;
            this.UserPrimitive = user;
        }

        public NumericKind NumericPrimitive {get;}

        public UserPrimitiveKind UserPrimitive{get;}         
    }
}