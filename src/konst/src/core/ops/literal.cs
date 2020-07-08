//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {                
        /// <summary>
        /// Reads an E-value from an enum of primal T-kind
        /// </summary>
        /// <param name="tVal">The integral value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E,T>(in T src)
            where E : unmanaged, Enum
            where T : unmanaged
                => ref @as<T,E>(src);
    }
}