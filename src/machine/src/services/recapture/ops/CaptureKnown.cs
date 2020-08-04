//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    partial struct Recapture
    {
        public CapturedAccessor[] CaptureKnown(ApiHostUri host, FilePath asmdst)
        {
            var assemblies = Context.ContextRoot.Composition.Assemblies;
            return CaptureAsm(host, Resources.accessors(assemblies), asmdst);
        }                
    }
}