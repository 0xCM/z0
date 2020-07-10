//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T escalar<E,T>(E eVal)
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumValue.scalar<E,T>(eVal);
    }
}