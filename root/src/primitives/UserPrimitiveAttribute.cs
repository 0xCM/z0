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
    public class UserPrimitiveAttribute : Attribute
    {
        public UserPrimitiveAttribute(object id)
        {
            this.UserId = (uint)Convert.ChangeType(id, typeof(int));
        }

        public readonly uint UserId;
    }

    /// <summary>
    /// Clasifies user-defined primitive types
    /// </summary>
    public readonly struct UserPrimitiveKind
    {
        public static UserPrimitiveKind None => Define(0);


        [MethodImpl(Inline)]
        public static UserPrimitiveKind Define(Type t, uint id) 
            => new UserPrimitiveKind(t,id);

        [MethodImpl(Inline)]
        public static UserPrimitiveKind Define(uint id) 
            => new UserPrimitiveKind(id);

        [MethodImpl(Inline)]
        public static implicit operator uint(UserPrimitiveKind src)
            => src.Id;
        

        [MethodImpl(Inline)]
        UserPrimitiveKind(uint id)
        {
            this.Id = id;
            this.Type = typeof(void);

        }

        [MethodImpl(Inline)]
        UserPrimitiveKind(Type t, uint id)
        {
            this.Id = id;
            this.Type = t;

        }
        
        public readonly uint Id;

        public readonly Type Type;

        public bool IsKnownType
        {
            [MethodImpl(Inline)]
            get => Type != typeof(void);
        }
    }
}