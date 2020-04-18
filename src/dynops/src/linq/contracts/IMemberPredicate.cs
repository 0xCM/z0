//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{

    using System;
    using System.Reflection;

    public interface IMemberPredicate : IPredicateAplication
    {

        MemberInfo Member { get; }
    }



}