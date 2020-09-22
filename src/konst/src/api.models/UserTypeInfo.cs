//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UserTypeInfo<T>
    {
        [MethodImpl(Inline)]
        internal UserTypeInfo(UserTypeCode<T> code)
        {
            this.TypeCode = code;
            this.DefiningType = typeof(T);
            this.IsParametric = typeof(T).IsGenericTypeDefinition;
            this.ParameterCount = IsParametric ? typeof(T).GetGenericArguments().Length : 0;
        }

        /// <summary>
        ///  The identity allocated to the type
        /// </summary>
        public UserTypeCode<T> TypeCode {get;}

        /// <summary>
        /// The implementation type
        /// </summary>
        public Type DefiningType  {get;}

        /// <summary>
        /// Specifies whether type arguments are required
        /// </summary>
        public bool IsParametric {get;}

        /// <summary>
        /// The number of type arguments required
        /// </summary>
        public int ParameterCount {get;}
    }
}