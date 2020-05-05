//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    public interface ICapturedCode<F,C> : IEncoded<F,C>
        where F : struct, IEncoded<F,C>
    {
        ExtractTermCode TermCode {get;}            
    }
}