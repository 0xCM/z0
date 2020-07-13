//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static CodeGenerator;
    using static Konst;

    public readonly struct ResourceProject
    {        
        public string Definition =>
            text.concat(
            Level0, "<Project Sdk='Microsoft.NET.Sdk'>", Eol,
            Level1, "<PropertyGroup>", Eol,
            Level2, "<OutputType>Library</OutputType>", Eol,
            Level2, "<DebugType>none</DebugType>", Eol,
            Level2, "<Prefer32Bit>false</Prefer32Bit>", Eol,
            Level2, "<DebugSymbols>false</DebugSymbols>", Eol,
            Level2, "<TargetFramework>netcoreapp3.0</TargetFramework>", Eol,
            Level1, "</PropertyGroup>", Eol,
            Level0, "</Project>", Eol);

        public ResourceProject(string name)
        {
            FileName = FileName.Define($"z0.res.{name}",FileExtension.Define("csproj"));
        }
        
        public readonly FileName FileName; 
    }
}