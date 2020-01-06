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


    public abstract class Deconstructable<T> : IDeconstructable<T>
        where T : Deconstructable<T>
    {
        readonly string SourcePath;
        
        protected Deconstructable(string SourcePath)
        {
            this.SourcePath = SourcePath;
        }

        public FilePath AsmTargetPath
            => FilePath.Define(Path.ChangeExtension(SourcePath, "asm"));

        public FilePath CilTargetPath
            => FilePath.Define(Path.ChangeExtension(SourcePath, "il"));

    }
}