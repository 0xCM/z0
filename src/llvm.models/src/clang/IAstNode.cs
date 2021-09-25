//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IAstNode : IArrow<uint>
    {
        AstNodeKind Kind {get;}
    }

    [Free]
    public interface IAstNode<T> : IAstNode
        where T : struct, IAstNode<T>
    {

    }
}