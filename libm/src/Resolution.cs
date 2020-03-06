//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class LibM : AssemblyResolution<LibM, LibM.C>
    {
        public LibM() : base(AssemblyId.LibM) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.LibM) { } }
    }
}