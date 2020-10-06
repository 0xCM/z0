//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a bitlogic operation classifier
    /// </summary>
    [Free]
    public interface IBitLogicKind : IApiKey, IOpKind<BinaryBitLogicApiKey>
    {
        BinaryBitLogicApiKey Kind {get;}

        NumericKind NumericKind
            => default;

        ApiOpId IApiKey.Id
            => (ApiOpId)Kind;
    }

    /// <summary>
    /// Characterizes a reified bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [Free]
    public interface IBitLogicKind<F> : IBitLogicKind, IOpKind<F,BinaryBitLogicApiKey>
        where F : unmanaged, IBitLogicKind
    {
        ApiOpId IApiKey.Id
            => default(F).Id;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    [Free]
    public interface IBitLogicKind<F,T> : IBitLogicKind<F>
        where F : unmanaged, IBitLogicKind
    {
        BinaryBitLogicApiKey IBitLogicKind.Kind
            => default(F).Kind;
    }
}