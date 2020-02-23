//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;    

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
             : base(id)
        {

        }
        
        // public override IEnumerable<ApiHost> DirectApiHosts
        //     => from t in items(typeof(LogicOpApi), typeof(LogicExprEval), typeof(LogicOps))
        //     select ApiHost.Define(AssemblyId, t);


        // public override IEnumerable<ApiHost> GenericApiHosts
        //     => from t in items(
        //         typeof(BitMatrixOpApi), typeof(BitMatrixOps), 
        //         typeof(BitVectorOpApi), typeof(BitVectorOps),
        //         typeof(ScalarOpApi), typeof(ScalarOps), 
        //         typeof(VectorOpApi), typeof(VectorizedOps),
        //         typeof(PredicateApi), typeof(LogicEngine),
        //         typeof(CmpExprEval), typeof(ArithExprEval),
        //         typeof(ScalarExprEval), 
        //         typeof(VectorExprEval)
        //         )
        //         select ApiHost.Define(AssemblyId, t);               
    }
}