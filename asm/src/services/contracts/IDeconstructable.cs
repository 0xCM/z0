//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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

}