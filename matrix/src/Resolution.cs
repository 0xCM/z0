//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class Matrix : AssemblyResolution<Matrix, Matrix.C>
    {
        const AssemblyId Identity = AssemblyId.Matrix;

        public Matrix() : base(Identity) {}
    
        public class C : OpCatalog<C> { public C() : base(Identity) { } }
    }
}