//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.clang
{
    using static Root;

    public interface IAstContainer
    {

    }

    public interface IAstContainer<C> : IAstContainer
        where C : IAstContainer<C>, new()
    {

    }

    public sealed partial class ClangAst : IAstContainer<ClangAst>
    {
        Index<string> Parts;

        public ClangAst()
        {
            Parts = sys.empty<string>();
        }

        ClangAst(string[] src)
        {
            Parts = src;
        }

        public static ClangAst create(string[] src)
            => new ClangAst(src);

    }
}