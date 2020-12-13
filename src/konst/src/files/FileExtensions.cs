//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FileKindNames;
    using static FS;

    public readonly struct FileExtensions
    {
        /// <summary>
        /// Defines a <see cref='asm'/> file extentions
        /// </summary>
        public static FileExt Asm => ext(asm);

        /// <summary>
        /// Defines a <see cref='cmd'/> file extentions
        /// </summary>
        public static FileExt Cmd => ext(cmd);

        /// <summary>
        /// Defines a <see cref='csproj'/> file extentions
        /// </summary>
        public static FileExt CsProj => ext(csproj);

        /// <summary>
        /// Defines a <see cref='csv'/> file extentions
        /// </summary>
        public static FileExt Csv => ext(csv);

        /// <summary>
        /// Defines a <see cref='cs'/> file extentions
        /// </summary>
        public static FileExt Cs => ext(cs);

        public static FileExt Dll => ext(dll);

        public static FileExt ErrorLog => ext(error) + Log;

        public static FileExt Exe => ext(exe);

        public static FileExt Hex => ext(hex);

        public static FileExt Idx => ext(idx, csv);

        public static FileExt Il => ext(il);

        public static FileExt IlData => ext(il, csv);

        public static FileExt Log => ext(log);

        public static FileExt Lib => ext(lib);

        public static FileExt Json => ext(json);

        public static FileExt JsonDeps => ext(deps, json);

        public static FileExt Pdb => ext(pdb);

        public static FileExt StatusLog => ext(status) + Log;

        public static FileExt Sln => ext(deps, sln);

        public static FileExt Targets => ext(targets);

        public static FileExt Txt => ext(txt);

        public static FileExt XCsv => ext(xcsv);

        public static FileExt PCsv => ext(pcsv);

        public static FileExt Xml => ext(xml);
    }
}