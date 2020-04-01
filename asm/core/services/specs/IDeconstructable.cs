//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    public interface IDeconstructable
    {
        void Emit();
    }

    public interface IDeconstructable<T> : IDeconstructable
        where T : IDeconstructable<T>
    {

    }

    public interface IAsmProcessEmitter
    {
        void EmitFunctions(Type host);
    }    
}