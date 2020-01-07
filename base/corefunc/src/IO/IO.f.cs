//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.IO;

using Z0;

partial class zfunc
{
    public static FilePath datapath(FolderName subject, FileName file)
        => Paths.DataPath(subject,file);

    public static StreamWriter datasink(FolderName subject, FileName file)
        => datapath(subject,file).LogWriter();

    public static StreamReader datasource(FolderName subject, FileName file)
        => datapath(subject,file).LogReader();

    /// <summary>
    /// Creates a caller-disposed log writer
    /// </summary>
    static StreamWriter LogWriter(this FilePath path)
    {
        path.FolderPath.CreateIfMissing();
        return new StreamWriter(path.ToString());
    }

    /// <summary>
    /// Creates a caller-disposed log reader
    /// </summary>
    static StreamReader LogReader(this FilePath path)
        => new StreamReader(path.ToString());

}