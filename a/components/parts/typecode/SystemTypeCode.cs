//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public readonly struct SystemTypeCode : ITypeCode
    {
        readonly TypeCode Code;

        [MethodImpl(Inline)]
        internal SystemTypeCode(TypeCode code)
        {
            this.IdentifiedType = Type.GetType($"System.{code}");
            this.Code = code;            
        }

        public ulong TypeId
        {
            [MethodImpl(Inline)]
            get => (ulong)Code;
        }

        public Type IdentifiedType {get;}
    }
}