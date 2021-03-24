//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RP
    {
        [RenderPattern(2, Property)]
        public const string Property = "{0}:{1}";

        [RenderPattern(4, Property2)]
        public const string Property2 ="{0}:{1} | {2}:{3}";

        [RenderPattern(6, Property3)]
        public const string Property3 ="{0}:{1} | {2}:{3} | {4}:{5}";

        [RenderPattern(8, Property4)]
        public const string Property4 ="{0}:{1} | {2}:{3} | {4}:{5} | {6}:{7}";

        [RenderPattern(10, Property5)]
        public const string Property5 ="{0}:{1} | {2}:{3} | {4}:{5} | {6}:{7} | {8}:{9}";

        [RenderPattern(12, Property6)]
        public const string Property6 ="{0}:{1} | {2}:{3} | {4}:{5} | {6}:{7} | {8}:{9} | {10}:{11}";
    }
}