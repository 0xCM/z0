//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using DataType = EmissionDataType;

    [ApiHost]
    public readonly struct PartDataEmitters
    {
        /// <summary>
        /// Creates an informational event
        /// </summary>
        /// <param name="id">The event identifier</param>
        /// <param name="description">The event description</param>
        [MethodImpl(Inline), Op]
        public static AppEvent create(StringRef id, string description, AppMsgColor flair = AppMsgColor.Blue)
            => new AppEvent(id,description,flair);

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
            var ev = create($"{status}", info, StartFlair);
            dst.Deposit(ev);
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
    }
}