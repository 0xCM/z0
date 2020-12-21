//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct ShowCmd : ICmdSpec<ListFilesCmd>
    {
        public const string CmdName = "show";

        /// <summary>
        /// The id/name of the thing to be shown
        /// </summary>
        public string Target;

        [MethodImpl(Inline)]
        public ShowCmd(string target)
        {
            Target = target;
        }
    }

    partial class XCmdSpecs
    {
        [MethodImpl(Inline), Op]
        public static ShowCmd Show(this CmdBuilder builder, string target)
        {
            var dst = new ShowCmd();
            dst.Target = target;
            return dst;
        }
    }
}