//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using X = ArchiveFileKinds;

    using static FS;

    [Free]
    public interface IFileExtensions
    {
        FileExt Cmd => X.Cmd;

        FileExt Asm => X.Asm;

        FileExt Csv => X.Csv;

        FileExt Cs => X.Cs;

        FileExt Dll => X.Dll;

        FileExt Pdb => X.Pdb;

        FileExt Xml => X.Xml;

        FileExt Json => X.Json;

        FileExt Exe => X.Exe;

        FileExt Txt => X.Txt;

        FileExt Il => X.Il;

        FileExt IlData => X.IlData;

        FileExt Hex => X.Hex;

        FileExt XCsv => X.XCsv;

        FileExt PCsv => X.PCsv;

        FileExt Log => X.Log;

        FileExt Lib => X.Lib;

        FileExt Idx => X.Idx;

        FileExt JsonDeps => X.JsonDeps;
    }
}