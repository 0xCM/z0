//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly partial struct ProjectModel
    {

    }

    public readonly struct ProjectTemplates
    {
        public const string P0 = @"
<Project Sdk='Microsoft.NET.Sdk'>
    <PropertyGroup>
      <TargetFramework>netcoreapp3.1</TargetFramework>
      <OutputType>Exe</OutputType>
    </PropertyGroup>

  <PropertyGroup>
    <Optimize>true</Optimize>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>true</DebugSymbols>
    <Prefer32Bit>false</Prefer32Bit>
    <LangVersion>preview</LangVersion>
    <SuppressNETCoreSdkPreviewMessage>true</SuppressNETCoreSdkPreviewMessage>
    <NoWarn>1591;1572;1573;1701;1702;1712;1711;1570;1571;1574;1710;8321;NETSDK1057;0169;0414;0219</NoWarn>
    <AssemblyVersion>1.0.41</AssemblyVersion>
    <VersionPrefix>$(AssemblyVersion)</VersionPrefix>
  </PropertyGroup>

  <ItemGroup>
    <CSFile Include='content/bytes/**/*.cs'/>
  </ItemGroup>

   <ItemGroup>
    <EmbeddedResource Include='content/**/*.cs' />
    <EmbeddedResource Include='content/**/*.asm' />
    <EmbeddedResource Include='content/**/*.csv' />
    <EmbeddedResource Include='content/**/*.hex' />
    <EmbeddedResource Include='content/**/*.md' />
  </ItemGroup>

</Project>
        ";

        public const string DirConfig = @"
<Project>
  <PropertyGroup>
    <TopDir>$(MsBuildThisFileDirectory)</TopDir>
    <BuildDir>$(TopDir).build\</BuildDir>
    <IntermediateBuildDir>$(BuildDir)obj\$(MSBuildProjectName)\</IntermediateBuildDir>
    <BaseIntermediateOutputPath>$(IntermediateBuildDir)</BaseIntermediateOutputPath>
    <IntermediateOutputPath>$(IntermediateBuildDir)</IntermediateOutputPath>
    <AppBinDir>$(BuildDir)bin\</AppBinDir>
    <OutputDir>$(AppBinDir)</OutputDir>
    <OutputPath>$(AppBinDir)</OutputPath>
  </PropertyGroup>
</Project>
        ";

        public const string CommonProperties = @"
            <Deterministic>true</Deterministic>
            <Optimize>true</Optimize>
            <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
            <LangVersion>preview</LangVersion>
            <DebugType>pdbonly</DebugType>
            <DebugSymbols>true</DebugSymbols>
            <NullableReferenceTypes>true</NullableReferenceTypes>
            <NullableContextOptions>disable</NullableContextOptions>
            <EmbedUntrackedSources>true</EmbedUntrackedSources>
            <IncludeSymbols>true</IncludeSymbols>
            <TopDir>$(MSBuildThisFileDirectory)</TopDir>
            <BuildRootDir>$(TopDir).build\</BuildRootDir>
            <OutputPath>$(BuildRootDir)bin\$(Configuration)\$(MsBuildProjectName)\</OutputPath>
            <DocumentationFile>$(OutputPath)$(TargetFramework)\$(MsBuildProjectName).xml</DocumentationFile>
            <IntermediateRoot>$(BuildRootDir)obj\$(Configuration)\$(MsBuildProjectName)\</IntermediateRoot>
            <IntermediateBuildDir>$(IntermediateRoot)</IntermediateBuildDir>
            <BaseIntermediateOutputPath>$(IntermediateRoot)</BaseIntermediateOutputPath>
            <IntermediateOutputPath>$(IntermediateRoot)</IntermediateOutputPath>
            <SuppressNETCoreSdkPreviewMessage>true</SuppressNETCoreSdkPreviewMessage>";
    }
}