//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Root;

    public interface IGenericOpSpec : IOpSpec
    {
        MethodInfo MethodDefinition {get;}        

        MethodInfo IOpSpec.Subject
            => MethodDefinition;
    }

}