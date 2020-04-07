//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class AsmSpecs
    {
        public interface address<W>
            where W : unmanaged, IDataWidth
        {
        }
        

        public interface address<F,W,S> : address<W>
            where F : struct, address<F,W,S>        
            where W : unmanaged, IDataWidth
            where S : unmanaged
        {
            S Location {get;}            
        }
    }
}