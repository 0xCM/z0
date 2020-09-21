//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TCheckDynamic : TValidator
    {
        IDynexus Dynamic => Dynops.Services.Dynexus;
    }
}