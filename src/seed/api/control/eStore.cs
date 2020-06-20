//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {                
        /// <summary>
        /// Stores an enum value of any primal kind to a u64 target
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong eStore<E>(in E eVal, out ulong tVal) 
            where E : unmanaged, Enum
                => ref EnumValue.eStore(eVal, out tVal);
    }
}