//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct Art 
    {
        readonly IArtistryContext Context;        

        [MethodImpl(Inline)]
        public Art(IArtistryContext context)
        {
            Context = context;
        }

        public void Display()
        {
            term.print("Nothing yet");      
        }
    }
}