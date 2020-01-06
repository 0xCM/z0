//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;

    public interface IDeconstructable
    {
        FilePath AsmTargetPath {get;}

        FilePath CilTargetPath {get;}

    }

    public interface IDeconstructable<T> : IDeconstructable
    {
    }

}