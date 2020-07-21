//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    partial struct AccessorCapture
    {
        public CapturedAccessor[] CaptureKnown(ApiHostUri host, FilePath asmdst)
        {
            var assemblies = Context.Api.Composition.Assemblies;
            return CaptureAsm(host, Resources.accessors(assemblies), asmdst);
        }                
    }
}