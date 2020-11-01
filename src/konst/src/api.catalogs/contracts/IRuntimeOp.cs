//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a runtime function of some sort
    /// </summary>
    [Free]
    public interface IRuntimeOp
    {

    }

    [Free]
    public interface IRuntimeOp<H> : IRuntimeOp
        where H : struct, IRuntimeOp<H>
    {

    }


    [Free]
    public interface IApiRuntimeOp : IRuntimeOp
    {

    }

    [Free]
    public interface IApiRuntimeOp<H> : IApiRuntimeOp, IRuntimeOp<H>
        where H : struct, IApiRuntimeOp<H>
    {
        ApiSig Sig {get;}
    }


    [Free]
    public interface IOperationExecutor
    {

    }

    [Free]
    public interface IOperationExecutor<H> : IOperationExecutor
        where H : IOperationExecutor<H>
    {

    }

}