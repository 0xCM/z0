//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static Root;

    partial struct Symbolic
    {        
        /// <summary>
        /// Creates value-to-symbol index
        /// </summary>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static IDictionary<T,char> index<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {            
            var values = Enums.dictionary<E,T>();
            var index = new Dictionary<T,char>();
            foreach(var kvp in values)
                index[kvp.Key] = kvp.Value.ToString().Last();
            return index;
        }


    }
}