//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct XedPattern : IRecord<XedPattern>
    {
        public string Class;

        public string Category;

        public string Extension;

        public string IsaSet;

        public string PatternText;

        public string OperandText;

        public string[] Parts;

        public string[] Operands;
    }
}