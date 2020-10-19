//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {


    }

    [Free, SFx]
    public interface IBinaryImm8Op<A> : IFunc<A,A,byte,A>
    {

    }
}