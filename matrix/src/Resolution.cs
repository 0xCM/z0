//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Matrix)]

namespace Z0.Resolutions
{
    public sealed class Matrix : AssemblyResolution<Matrix, Matrix.C>
    {
        const AssemblyId Identity = AssemblyId.Matrix;

        public Matrix() : base(Identity) {}
    
        public class C : ApiCatalog<C> { public C() : base(Identity) { } }
    }
}