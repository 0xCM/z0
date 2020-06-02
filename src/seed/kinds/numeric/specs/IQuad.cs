//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

   /// <summary>
    /// Characterizes an homogenous 4-tuple
    /// </summary>
    /// <typeparam name="K">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IQuad<K,T> : ITuple<K>, ITupled<K,T,T,T,T>
        where K : IQuad<K,T>
    {
        T First {get;}        

        T Second {get;}

        T Third {get;}

        T fourth {get;}
    }
}