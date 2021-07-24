//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct VarDecorators
    {
        public static VarDecorator CmdVar => "%{0}%";

        public static VarDecorator MsBuildVar => "$(0)";
    }
}