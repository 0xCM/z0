//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
using Meta.Core;
using System;
using System.Linq;
using Meta.Core.Modules;

partial class etude
{

    /// <summary>
    /// Implements the <![CDATA[<|>]]> operator for indexes
    /// </summary>
    /// <typeparam name="X">The item type</typeparam>
    /// <param name="l1">The first index</param>
    /// <param name="l2">The second index</param>
    /// <returns></returns>
    public static IndexImmutable<X> alt<X>(IndexImmutable<X> s1, IndexImmutable<X> s2)
        => IndexImmutable.concat(s1, s2);

}


