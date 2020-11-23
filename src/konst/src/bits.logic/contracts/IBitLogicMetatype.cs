//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBitLogicMetatype<H,T> : IBitLogicKind<H,T>
        where H : unmanaged, IBitLogicKind
    {
        NumericKind IBitLogicKind.NumericKind
            => NumericKinds.kind<T>();
    }

    /// <summary>
    /// Characterizes a kind, numeric, and width-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    [Free]
    public interface IBitLogicMetatype<F,W,T> : IBitLogicKind<F,T>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IBitLogicKind
    {
        /// <summary>
        /// The parametrically-identified operand width
        /// </summary>
        TypeWidth OperandWidth {get;}
    }
}