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