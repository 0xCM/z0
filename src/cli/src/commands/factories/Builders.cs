namespace Z0
{
    using System.Runtime.CompilerServices;
    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static EmitImageHeadersCmd EmitImageHeaders(this ICmdCatalog wf)
            => default;

    }
}
