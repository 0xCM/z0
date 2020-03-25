//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IFixedChar : IFixed
    {
        ReadOnlySpan<char> Individuals {get;}        
    }

    public interface IFixedChar<C> : IFixedChar
        where C : unmanaged    
    {
        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<C>();
        }                       
    }

}