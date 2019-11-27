//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using System.Collections;


    /// <summary>
    /// Stateless enum enumerator
    /// </summary>
    readonly struct EnumValueEnumerator<E> : IEnumerable<E>
        where E : Enum
    {
        static EnumValues<E> Values => EnumValues<E>.TheOnly;
         
        public IEnumerator<E> GetEnumerator() => Values.Enumerate().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}