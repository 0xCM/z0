//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using System.Linq;
     
    using EK = EmissionDataType;
    using WS = WfStatusKind;
    using WK = WfKind;
    using Target = IAppEventSink;

    [ApiHost]
    public readonly struct MetadataEmitters
    {
        [MethodImpl(Inline), Op]
        public static string format(DateTime src)
            => src.ToLexicalString();

        [MethodImpl(Inline), Op]
        public static string format(WK kind)
        {
            return $"{kind}";
        }

        [MethodImpl(Inline), Op]
        public static string format(WS status)
        {
            return $"{status}";
        }

        public static void status(WK kind, WS status, Target dst)
        {            
            var ts = format(z.now());
            var info = text.concat(ts, Space, FieldDelimiter, Space, format(kind), Space, FieldDelimiter, Space, format(status));
            var ev = Events.create($"{status}", info, StartFlair);
            dst.Deposit(ev);
        }

        const AppMsgColor StartFlair = AppMsgColor.Blue;

        const AppMsgColor EndFlair = AppMsgColor.Cyan;

        static FileExtension ExtX(EK mk)
            => FileExtension.Define(mk switch {
                _ => mk.ToString().ToLower(),
            });

        public static FileExtension ext(EK mk)
        {
            if(mk ==EK.HexLine)
                return FileExtension.Define("dat");
            else
                return FileExtension.Define($"{ExtX(mk)}.{FileExtensions.Csv}");
        }

        public static FileName filename(EK mk, PartRecordKind rk)
            => FileName.Define($"{rk.ToString().ToLower()}", mk.Ext());
        
        public static void emitting(EK mk, Target dst)
            => dst.Deposit(Events.create($"{mk}_running", $"Emitting {mk} data files", StartFlair));

        public static void emitting(EK mk, FilePath path, Target dst)
            => dst.Deposit(Events.create($"{mk}_running", $"{mk}: {path}", StartFlair));

        public static void emitted(EK mk, Target dst)
            => dst.Deposit(Events.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));

        public static void emitting(PartRecordKind rk,  FilePath path, Target dst)
            => dst.Deposit(Events.create($"{rk}_running", $"{rk}: {path}", StartFlair));

        public static void emitted(PartRecordKind rk, PartId part, Target dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Emitted {rk} {part.Format()} records", EndFlair));

        public static void running(FolderPath path, Target dst)        
            => dst.Deposit(Events.create("prepare", $"Preparing archive {path}", StartFlair));

        public static void ran(FolderPath path, Target dst)        
            => dst.Deposit(Events.create("prepared", $"Prepared archive {path}", EndFlair));

        public static void ran(EK mk, PartId part, FilePath path, Target dst)
            => dst.Deposit(Events.create($"{mk}_{part}", $"Emitted {mk} {part.Format()} records to {path}", EndFlair));

        public static void ran(PartRecordKind rk, Target dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Completed {rk} emission", EndFlair));

        public static void ran(EK mk, Target dst)
            => dst.Deposit(Events.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));
    }
}