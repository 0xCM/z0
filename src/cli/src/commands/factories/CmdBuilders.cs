namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static EmitImageHeadersCmd EmitImageHeaders(this CmdBuilder wf)
            => default;
    }
}