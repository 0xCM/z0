//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static PartRecords;
    using DataType = EmissionDataType;
    using WfSink = IAppEventSink;

    [ApiHost]
    public readonly struct PartDataEmitters
    {
        [MethodImpl(Inline), Op]
        public static string format(DateTime src)
            => src.ToLexicalString();

        [MethodImpl(Inline), Op]
        public static string format(WfKind kind)
        {
            return $"{kind}";
        }

        [MethodImpl(Inline), Op]
        public static string format(WfStatusKind status)
        {
            return $"{status}";
        }

        public static void status(WfKind kind, WfStatusKind status, IAppContext dst)
        {            
            var ts = format(z.now());
            var info = text.concat(ts, Space, FieldDelimiter, Space, format(kind), Space, FieldDelimiter, Space, format(status));
            var ev = Events.create($"{status}", info, StartFlair);
            dst.Deposit(ev);
        }

        public static void Deposit(BlobRecord src, IDatasetFormatter<BlobField> dst)
        {
            dst.Delimit(BlobField.Sequence, src.Sequence);
            dst.Delimit(BlobField.HeapSize, src.HeapSize);
            dst.Delimit(BlobField.Offset, src.Offset);
            dst.Delimit(BlobField.Value, src.Value);
            dst.EmitEol();            
        }
        
        const AppMsgColor StartFlair = AppMsgColor.Blue;

        const AppMsgColor EndFlair = AppMsgColor.Cyan;

        static FileExtension ExtX(DataType mk)
            => FileExtension.Define(mk switch {
                _ => mk.ToString().ToLower(),
            });

        public static FileExtension ext(DataType type)
        {
            if(type ==DataType.PartDat)
                return FileExtension.Define("dat");
            else
                return FileExtension.Define($"{ExtX(type)}.{FileExtensions.Csv}");
        }

        public static FileName filename(DataType type, PartRecordKind rk)
            => FileName.Define($"{rk.ToString().ToLower()}", type.Ext());
        
        public static void emitting(DataType type, IAppContext dst)
            => dst.Deposit(Events.create($"{type}_running", $"Emitting {type} data files", StartFlair));

        public static void emitting(DataType type, FilePath path, IAppContext dst)
            => dst.Deposit(Events.create($"{type}_running", $"{type}: {path}", StartFlair));

        public static void emitted(DataType type, IAppContext dst)
            => dst.Deposit(Events.create($"{type}_ran", $"Completed {type} emission", EndFlair));

        public static void emitting(PartRecordKind rk,  FilePath path, IAppContext dst)
            => dst.Deposit(Events.create($"{rk}_running", $"{rk}: {path}", StartFlair));

        public static void emitted(PartRecordKind rk, PartId part, IAppContext dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Emitted {rk} {part.Format()} records", EndFlair));

        public static void running(FolderPath path, IAppContext dst)        
            => dst.Deposit(Events.create("prepare", $"Preparing archive {path}", StartFlair));

        public static void ran(FolderPath path, IAppContext dst)        
            => dst.Deposit(Events.create("prepared", $"Prepared archive {path}", EndFlair));

        public static void ran(DataType type, PartId part, FilePath path, IAppContext dst)
            => dst.Deposit(Events.create($"{type}_{part}", $"Emitted {type} {part.Format()} records to {path}", EndFlair));

        public static void ran(PartRecordKind rk, IAppContext dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Completed {rk} emission", EndFlair));

        public static void ran(DataType type, IAppContext dst)
            => dst.Deposit(Events.create($"{type}_ran", $"Completed {type} emission", EndFlair));
    }
}