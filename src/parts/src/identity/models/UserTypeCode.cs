//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public static class UserTypeCode
    {
        [MethodImpl(Inline)]
        public static UserTypeCode<T> Define<T>(ITypeCodeSource src, ulong id)
        {
            if(!src.AssignedCodes.Contains(id))
               throw new Exception($"I dont understand {typeof(T)}");
            return new UserTypeCode<T>(id);
        }
    }

    public readonly struct UserTypeCode<T> : ITypeCode<T>
    {        
        /// <summary>
        /// A numeric value, greater than 255, that uniquely identifies a user-defined type 
        /// </summary>
        readonly ulong Code;

        [MethodImpl(Inline)]
        public static implicit operator TypeCode<T>(UserTypeCode<T> src)
            => new TypeCode<T>(src.Code);

        [MethodImpl(Inline)]
        internal UserTypeCode(ulong code)
        {
            this.Code = code;
        }

        public ulong TypeId
        {
            [MethodImpl(Inline)]
            get => Code;
        }
    }
}