//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IRenderService
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    [Free]
    public interface IRenderService<S,T,B> : IRenderService
        where B : IRenderBuffer<S,T>
    {
        void Render(S src, B dst);

        Type IRenderService.SourceType => typeof(S);

        Type IRenderService.TargetType => typeof(T);
    }
}