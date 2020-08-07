//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        /// <summary>
        /// Identifies a step predicated on a specified type name and kind
        /// </summary>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>        
        [MethodImpl(Inline)]
        public static WfStepId step<K,T>(K kind, T type)
            where K : unmanaged, Enum
                => new WfStepId(z.uint64(kind), typeof(T).Name);

        [MethodImpl(Inline)]
        public static WfStepId step<K>(K kind, Type type)
            where K : unmanaged, Enum
                => new WfStepId(z.uint64(kind), type.Name);
    }
}