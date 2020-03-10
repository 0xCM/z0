//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class FileExtensions
    {
        public static FileExtension Csv => FileExtension.Define("csv");

        public static FileExtension Asm =>  FileExtension.Define("asm");

        public static FileExtension Il =>  FileExtension.Define("il");

        public static FileExtension Hex =>  FileExtension.Define("hex");

        public static FileExtension Raw =>  FileExtension.Define("raw");

        public static FileExtension Log =>  FileExtension.Define("log");
        
    }
}