//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IByteSpanProvider
    {
        ReadOnlySpan<byte> Bytes {get;}

        int Length 
            => Bytes.Length;

        ref readonly byte Head 
        { 
            [MethodImpl(Inline)] 
            get => ref Imagine.first(Bytes);
        }
        
        ref readonly byte this[int index] 
        {
             [MethodImpl(Inline)]  
             get => ref Imagine.skip(Head, index); 
        }
    }
}