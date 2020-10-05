//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ArchiveNames.Ext;
    using static FS;

    /// <summary>
    /// Common file extentions
    /// </summary>
    public readonly struct ArchiveExt
    {
        public static FileExt Asm => ext(asm);

        public static FileExt Csv => ext(csv);

        public static FileExt Cil => ext(cil);

        public static FileExt Txt => ext(txt);

        public static FileExt Cpp => ext(cpp);

        public static FileExt Cs => ext(cs);

        public static FileExt Dll => ext(dll);

        public static FileExt Exe => ext(exe);

        public static FileExt Hex => ext(hex);

        public static FileExt Lib => ext(lib);

        public static FileExt Json => ext(json);

        public static FileExt Log => ext(log);

        public static FileExt Pdb => ext(pdb);

        public static FileExt Xml => ext(xml);

        public static FileExt StatusLog => ext(status) + Log;

        public static FileExt ErrorLog => ext(error) + Log;
    }
}