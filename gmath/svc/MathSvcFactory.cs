//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Resolutions;

    [OpServiceFactoryProvider(MathServices.SvcCollectionName)]
    public partial class MathSvcFactory : OpSvcFactoryProvider<MathSvcFactory>
    {

    }
}