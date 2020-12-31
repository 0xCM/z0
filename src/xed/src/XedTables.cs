//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static XedSourceMarkers;

    using F = XedPatternField;
    using XF = XedInstructionField;

    [ApiHost]
    public readonly partial struct XedTables
    {
        [Op]
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

        [Op]
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

        [Op]
        public static XedPatternRow row(in XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOfFirst(ASSIGN).Trim(), EmptyString);
            var dst = new XedPatternRow();
            dst.Class = src.Class;
            dst.Category = src.Category;
            dst.Extension =  src.Extension;
            dst.IsaSet =  src.IsaSet;
            dst.BaseCode =  Xed.code(src);
            dst.Mod =  Xed.mod(src);
            dst.Reg =  Xed.reg(src);
            dst.Pattern =  src.PatternText;
            dst.Operands =  src.OperandText;
            return dst;
        }

        [Op]
        public static string format(in XedPattern src, char delimiter)
        {
            var dst = Table.formatter<XedPatternField>(delimiter);
            render(src,dst);
            return dst.Format();
        }

        [Op]
        public static string format(in XedPatternRow src, char delimiter)
        {
            var dst = Table.formatter<XedPatternField>(delimiter);
            render(src, dst);
            return dst.Format();
        }

        [MethodImpl(Inline), Op]
        public static string format(in XedInstructionRow src, in DatasetFormatter<XedInstructionField> dst)
            => render(src, dst).Render();


        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFieldFormatter<XedPatternField> render(in XedPattern src, in DatasetFieldFormatter<XedPatternField> dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, Xed.code(src));
            dst.Delimit(F.Mod, Xed.mod(src));
            dst.Delimit(F.Reg, Xed.reg(src));
            dst.Delimit(F.Pattern, src.PatternText);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFieldFormatter<XedPatternField> render(in XedPatternRow src, in DatasetFieldFormatter<XedPatternField> dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode);
            dst.Delimit(F.Mod, src.Mod);
            dst.Delimit(F.Reg, src.Reg);
            dst.Delimit(F.Pattern, src.Pattern);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly DatasetFormatter<XedInstructionField> render(in XedInstructionRow src, in DatasetFormatter<XedInstructionField> dst)
        {
            dst.Delimit(XF.Sequence, src.Sequence);
            dst.Delimit(XF.Mnemonic, src.Mnemonic);
            dst.Delimit(XF.Extension, src.Extension);
            dst.Delimit(XF.BaseCode, src.BaseCode);
            dst.Delimit(XF.Mod, src.Mod);
            dst.Delimit(XF.Reg, src.Reg);
            return ref dst;
        }
    }
}
