//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICheckDynamic : IValidator
    {
        IDynexus Dynamic => Dynops.Dynexus;
    }
}