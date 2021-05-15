//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FileKindNames;

    partial struct FS
    {
        /// <summary>
        /// Defines the <see cref='asm'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Asm => ext(asm);

        /// <summary>
        /// Defines the <see cref='bin'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Bin => ext(bin);

        /// <summary>
        /// Defines the <see cref='cmd'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Cmd => ext(cmd);

        /// <summary>
        /// Defines the <see cref='csv'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Csv => ext(csv);

        /// <summary>
        /// Defines the <see cref='dll'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Dll => ext(dll);

        /// <summary>
        /// Defines the <see cref='exe'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Exe => ext(exe);

        /// <summary>
        /// Defines the <see cref='hex'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Hex => ext(hex);

        /// <summary>
        /// Defines the <see cref='log'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Log => ext(log);

        /// <summary>
        /// Defines the <see cref='lib'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Lib => ext(lib);

        /// <summary>
        /// Defines the <see cref='il'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Il => ext(il);

        /// <summary>
        /// Defines the composite <see cref='il'/> + <see cref='csv'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt IlData => ext(il, csv);

        /// <summary>
        /// Defines the <see cref='json'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Json => ext(json);

        /// <summary>
        /// Defines the <see cref='pdb'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Pdb => ext(pdb);

        /// <summary>
        /// Defines the <see cref='ps1'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Ps1 => ext(ps1);

        /// <summary>
        /// Defines the <see cref='cs'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Cs => ext(cs);

        /// <summary>
        /// Defines the <see cref='csproj'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt CsProj => ext(csproj);

        /// <summary>
        /// Defines the <see cref='txt'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Txt => ext(txt);

        /// <summary>
        /// Defines the <see cref='statements'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Statements => ext(statements);

        /// <summary>
        /// Defines the composite <see cref='xcsv'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt XCsv => ext(xcsv);

        /// <summary>
        /// Defines the composite <see cref='pcsv'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt PCsv => ext(pcsv);

        /// <summary>
        /// Defines the <see cref='idx'/> + <see cref='csv'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Idx => ext(idx, csv);

        /// <summary>
        /// Defines the <see cref='xml'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Xml => ext(xml);

        /// <summary>
        /// Defines the <see cref='zip'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Zip => ext(zip);

        /// <summary>
        /// Defines the composite <see cref='djson'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt JsonDeps => ext(djson);

        /// <summary>
        /// Defines the <see cref='sln'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Sln => ext(sln);

        /// <summary>
        /// Defines the <see cref='h'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt H => ext(h);

        /// <summary>
        /// Defines the <see cref='targets'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Targets => ext(targets);

        /// <summary>
        /// Defines the <see cref='alg'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Alg => ext(alg);

        /// <summary>
        /// Defines the <see cref='dmp'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Dmp => ext(dmp);

        /// <summary>
        /// Defines the <see cref='xpack'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt XPack => ext(xpack);

        /// <summary>
        /// Defines the <see cref='bat'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Bat => ext(bat);

        /// <summary>
        /// Defines the <see cref='sh'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Sh => ext(sh);

        /// <summary>
        /// Defines the <see cref='settings'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Settings => ext(settings);

        /// <summary>
        /// Defines the <see cref='config'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Config => ext(config);

        /// <summary>
        /// Defines the composite <see cref='cjson'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt JsonConfig => ext(cjson);

        /// <summary>
        /// Defines the <see cref='status'/> + <see cref='log'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt StatusLog => ext(status) + Log;

        /// <summary>
        /// Defines the <see cref='error'/> + <see cref='log'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt ErrorLog => ext(error) + Log;

        /// <summary>
        /// Defines the <see cref='cfg'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Cfg => ext(cfg);

        /// <summary>
        /// Defines the <see cref='dot'/> <see cref='FileExt'/>
        /// </summary>
        public static FileExt Dot => ext(dot);
    }
}