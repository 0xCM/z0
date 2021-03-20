//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitImageMapsCmd  : ICmd<EmitImageMapsCmd>
    {
        public const string CmdName ="emit-image-maps";

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [Op]
        public static EmitImageMapsCmd EmitImageMaps(this CmdBuilder builder)
        {
            var dst = new EmitImageMapsCmd();
            dst.Target = builder.Db.IndexFile(LocatedImageRow.TableId);
            return dst;
        }

        [Op]
        public static EmitImageMapsCmd EmitImageMaps(this CmdBuilder builder, string id)
        {
            var dst = new EmitImageMapsCmd();
            dst.Target = builder.Db.IndexFile(LocatedImageRow.TableId + "." + id);
            return dst;
        }

    }
}