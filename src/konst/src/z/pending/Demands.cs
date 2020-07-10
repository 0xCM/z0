//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    [ApiHost]
    public readonly struct Demands
    {        
        [MethodImpl(Inline), Op]
        public static void insist(bool invariant)
            => z.insist(invariant);

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, string msg)
            => z.insist(invariant, msg);    

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
                => z.insist(lhs,rhs);                  
    }
}