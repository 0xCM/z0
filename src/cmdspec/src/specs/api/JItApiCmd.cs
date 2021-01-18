namespace Z0
{
    [Cmd(CmdName)]
    public struct JitApiCmd : ICmd<JitApiCmd>
    {
        public const string CmdName = "jit-api";
    }

    partial class XCmd
    {
        [Op]
        public static JitApiCmd JitApiCmd(this CmdBuilder builder)
            => new JitApiCmd();
    }
}