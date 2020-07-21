//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAccessorCapture : IContextual<IAppContext>
    {
        FolderPath ResBytesDir
            => Context.AppPaths.AppDataRoot + FolderName.Define("resbytes");

        /// <summary>
        /// The x86 resource assembly output path - which was created by disassembling most of z0
        /// </summary>
        FilePath ResBytesCompiled
            => FilePath.Define(@"J:\dev\projects\z0-logs\res\bin\lib\netcoreapp3.0\z0.res.dll");

        /// <summary>
        /// The target directory that receives data obtained by disassembling the resource disassembly file <see cref='ResBytesCompiled'/>
        /// </summary>
        FolderPath ResBytesUncompiled
            => ResBytesDir + FolderName.Define("asm");
    }
}