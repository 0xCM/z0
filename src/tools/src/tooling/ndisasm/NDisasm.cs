//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    [ApiHost]
    public sealed partial class NDisasm : ToolService<NDisasm>
    {
        public NDisasm()
            : base(Toolsets.ndisasm)
        {

        }
    }
}