//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IDeconstructable
    {
        FolderPath TargetFolder {get;}

        FileName AsmFileName {get;}

        FileName CilFileName {get;}

        void Emit();

    }

    public interface IDeconstructable<T> : IDeconstructable
        where T : IDeconstructable<T>
    {

    }

}