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

        public interface scalar<W,T> : IMeasured<W>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            T Value {get;}     
            
        }    

        public interface scalar<F,W,T> : scalar<W,T>
            where F : unmanaged, scalar<F,W,T>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            
        }    
    }
}