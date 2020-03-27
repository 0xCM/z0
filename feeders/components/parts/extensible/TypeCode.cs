//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Components;

    public interface ITypeCode
    {
        ulong TypeId {get;}

        Type IdentifiedType {get;}
    }

    public interface ITypeCode<T> : ITypeCode
    {
        Type ITypeCode.IdentifiedType
        {
            [MethodImpl(Inline)]
            get => typeof(T);
        }

        [MethodImpl(Inline)]
        TypeCode<T> Concretize()
            => new TypeCode<T>(TypeId);        
    }
    
    public readonly struct TypeCode<T> : ITypeCode<T>
    {
        /// <summary>
        /// A numeric value intented to uniquely identify a system-defined or user-defiend type. 
        /// The least 8 bits are reserved for a System.TypeCode enum value for system-defined types;
        /// the remaining bits are then reserved for user-defined types
        /// </summary>
        readonly ulong Code;

        [MethodImpl(Inline)]
        internal TypeCode(ulong code)
        {
            this.Code = code;
        }

        public bool IsUserDefined
        {
            [MethodImpl(Inline)]
            get => Code >= 256;
        }

        public TypeCode SystemCode
        {
            [MethodImpl(Inline)]
            get => IsUserDefined ? 0 : (TypeCode)Code;
        }      
                  
        public ulong TypeId
        {
            [MethodImpl(Inline)]
            get => Code;
        }        
    }
}