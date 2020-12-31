//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    public readonly partial struct Xed
    {
        public static Index<XedPatternRow> patterns(ITableArchive archive)
        {
            var src = archive.TablePath(FS.file(XedPatternRow.TableId, FileExtensions.Csv));
            var doc = archive.Document(src).Require();
            var count = doc.RowCount;
            var buffer = sys.alloc<XedPatternRow>(count);
            if(count != 0)
            {
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                    load(doc[i], ref seek(dst, i));
            }

            return buffer;
        }

        static bool load(in TextRow src, ref XedPatternRow dst)
        {
            if(src.CellCount == 9)
            {
                var i=0;
                dst.Class = src[i++];
                dst.Category = src[i++];
                dst.Extension = src[i++];
                dst.IsaSet = src[i++];
                dst.BaseCode = HexByteParser.Service.ParseData(src[i++]).Value ?? BinaryCode.Empty;
                dst.Mod = src[i++];
                dst.Reg = src[i++];
                dst.Pattern = src[i++];
                dst.Operands = src[i++];
                return true;
            }

            return false;
        }
    }
}